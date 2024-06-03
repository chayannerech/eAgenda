using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
namespace eAgenda.WinApp.ModuloCompromisso
{
    internal class ControladorCompromisso : ControladorBase, IControladorFiltravel
    {
        private RepositorioCompromisso repositorioCompromisso;
        private RepositorioContato repositorioContato;
        private TabelaCompromissoControl tabelaCompromisso;
        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.repositorioContato = repositorioContato;
        }
        public override string TipoCadastro { get => "Compromissos"; }
        public override string ToolTipAdicionar { get => "Adicionar novo compromisso"; }
        public override string ToolTipEditar { get => "Editar compromisso existente"; }
        public override string ToolTipExcluir { get => "Excluir compromisso existente"; }
        public string ToolTipFiltrar { get => "Filtrar compromissos"; }


        public override void Adicionar()
        {
            TelaCompromissoForm telaCompromisso = new();

            List<Contato> contatosCadastrados = repositorioContato.SelecionarTodos();
            telaCompromisso.CarregarContatos(contatosCadastrados);

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Compromisso novoCompromisso = telaCompromisso.Compromisso;

            RealizaAcao(
                () => repositorioCompromisso.Cadastrar(novoCompromisso),
                novoCompromisso, "criado");
        }

        public override void Editar()
        {
            TelaCompromissoForm telaCompromisso = new();

            List<Contato> contatosCadastrados = repositorioContato.SelecionarTodos();

            telaCompromisso.CarregarContatos(contatosCadastrados);
            
            int idSelecionado = tabelaCompromisso.ObterRegistroSelecionado();

            Compromisso compromissoSelecionado = repositorioCompromisso.SelecionarPorId(idSelecionado);

            if (SemSeleção(compromissoSelecionado)) return;
            
            telaCompromisso.Compromisso = compromissoSelecionado;

            DialogResult resultado = telaCompromisso.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Compromisso contatoEditado = telaCompromisso.Compromisso;
            
            RealizaAcao(
                () => repositorioCompromisso.Editar(compromissoSelecionado.Id, contatoEditado), 
                contatoEditado, "editado");
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaCompromisso.ObterRegistroSelecionado();

            Compromisso compromissoSelecionado = repositorioCompromisso.SelecionarPorId(idSelecionado);

            if (SemSeleção(compromissoSelecionado)) return;

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o compromisso \"{compromissoSelecionado.Assunto}\"?",
                $"Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes) return;

            RealizaAcao(
                () => repositorioCompromisso.Excluir(compromissoSelecionado.Id),
                compromissoSelecionado, "excluído");
        }

        public void Filtrar()
        {
            TelaFiltroCompromisso telaFiltro = new();

            DialogResult resultado = telaFiltro.ShowDialog();

            if (resultado != DialogResult.OK) return;

            TipoFiltroCompromissoEnum filtroSelecionado = telaFiltro.FiltroSelecionado;

            List<Compromisso> compromissosSelecionados;

            if (filtroSelecionado == TipoFiltroCompromissoEnum.Futuros)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosFuturos();

            else if (filtroSelecionado == TipoFiltroCompromissoEnum.Passados)
                compromissosSelecionados = repositorioCompromisso.SelecionarCompromissosPassados();
            
            else compromissosSelecionados = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissosSelecionados);

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {compromissosSelecionados.Count} registros");
        }

        public override UserControl ObterListagem()
        {
            tabelaCompromisso ??= new TabelaCompromissoControl();

            CarregarContatos();
            return tabelaCompromisso;
        }
        private void CarregarContatos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.SelecionarTodos();

            tabelaCompromisso.AtualizarRegistros(compromissos);
        }
        private void CarregaMensagem(Compromisso compromisso, string texto)
        {
            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{compromisso.Assunto}\" foi {texto} com sucesso!");
        }
        private void RealizaAcao(Action acao, Compromisso compromisso, string texto)
        {
            acao();
            CarregarContatos();
            CarregaMensagem(compromisso, texto);
        }
    }
}
