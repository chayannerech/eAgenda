using eAgenda.WinApp.Compartilhado;
namespace eAgenda.WinApp.ModuloContato
{
    internal class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private TabelaContatoControl tabelaContatos;
        public ControladorContato(RepositorioContato repositorioContato)
            => this.repositorioContato = repositorioContato;

        public override string TipoCadastro { get => "Contatos"; }
        public override string ToolTipAdicionar { get => "Adicionar novo contato"; }
        public override string ToolTipEditar { get => "Editar contato existente"; }
        public override string ToolTipExcluir { get => "Excluir contato existente"; }


        public override void Adicionar()
        {
            TelaCompromissoForm telaContato = new();
            DialogResult resultado = telaContato.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Contato novoContato = telaContato.Contato;

            RealizaAcao(
                () => repositorioContato.Cadastrar(novoContato),
                novoContato, "criado");
        }
        public override void Editar()
        {
            TelaCompromissoForm telaContato = new();

            int idSelecionado = tabelaContatos.ObterRegistroSelecionado();
            
            Contato contatoSelecionado = repositorioContato.SelecionarPorId(idSelecionado);

            if (SemSeleção(contatoSelecionado)) return;

            telaContato.Contato = contatoSelecionado;

            DialogResult resultado = telaContato.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Contato contatoEditado = telaContato.Contato;
            RealizaAcao(
                () => repositorioContato.Editar(contatoSelecionado.Id, contatoEditado), 
                contatoEditado, "editado");
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaContatos.ObterRegistroSelecionado();

            Contato contatoSelecionado = repositorioContato.SelecionarPorId(idSelecionado);
            
            if (SemSeleção(contatoSelecionado)) return;

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{contatoSelecionado.Nome}\"?",
                $"Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning );

            if (resposta != DialogResult.Yes) return;

            RealizaAcao(
                () => repositorioContato.Excluir(contatoSelecionado.Id),
                contatoSelecionado, "excluído");
        }


        public override UserControl ObterListagem()
        {
            tabelaContatos ??= new TabelaContatoControl();

            CarregarContatos();
            return tabelaContatos;
        }
        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.SelecionarTodos();

            tabelaContatos.AtualizarRegistros(contatos);
        }
        private void CarregaMensagem(Contato contato, string texto)
        {
            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{contato.Nome}\" foi {texto} com sucesso!");
        }
        private void RealizaAcao(Action acao, Contato contato, string texto)
        {
            acao();
            CarregarContatos();
            CarregaMensagem(contato, texto);
        }
    }
}
