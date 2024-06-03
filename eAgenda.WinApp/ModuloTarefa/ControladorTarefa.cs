using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
namespace eAgenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa (RepositorioTarefa repositorioTarefa) : ControladorBase, IControladorSubItens
    {
        private RepositorioTarefa repositorioTarefa = repositorioTarefa;
        private TabelaTarefaControl tabelaTarefa;
        public override string TipoCadastro { get => "Tarefas"; }
        public override string ToolTipAdicionar { get => "Adicionar nova tarefa"; }
        public override string ToolTipEditar { get => "Editar tarefa existente"; }
        public override string ToolTipExcluir { get => "Excluir tarefa existente"; }
        public string ToolTipFiltrar { get => "Filtrar tarefas"; }
        public string ToolTipAdicionarItens  { get => "Adicionar itens para uma tarefa"; }
        public string ToolTipConcluirItens { get => "Concluir itens de uma tarefa"; }

        public override void Adicionar()
        {
            TelaTarefaForm telaTarefa = new();

            DialogResult resultado = telaTarefa.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Tarefa novaTarefa = telaTarefa.Tarefa;

            RealizaAcao(
                () => repositorioTarefa.Cadastrar(novaTarefa),
                novaTarefa, "criado");
        }
        public override void Editar()
        {
            TelaTarefaForm telaTarefa = new();

            int idSelecionado = tabelaTarefa.ObterIdSelecionado();
            
            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (SemSeleção(tarefaSelecionada)) return;

            telaTarefa.Tarefa = tarefaSelecionada;

            DialogResult resultado = telaTarefa.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Tarefa tarefaEditada = telaTarefa.Tarefa;
            RealizaAcao(
                () => repositorioTarefa.Editar(tarefaSelecionada.Id, tarefaEditada),
                tarefaEditada, "editado");
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaTarefa.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (SemSeleção(tarefaSelecionada)) return;

            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{tarefaSelecionada.Titulo}\"?",
                $"Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes) return;

            RealizaAcao(
                () => repositorioTarefa.Excluir(tarefaSelecionada.Id),
                tarefaSelecionada, "excluído");
        }
        public void AdicionarItens()
        {
            int idSelecionado = tabelaTarefa.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (SemSeleção(tarefaSelecionada)) return;

            TelaCadastroItemTarefa tela = new(tarefaSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            List<ItemTarefa> itens = tela.ItensAdicionados;

            RealizaAcao(
                () => repositorioTarefa.AdicionarItens(tarefaSelecionada, itens),
                tarefaSelecionada, "adicionado");
        }
        public void AtualizarItens()
        {
            int idSelecionado = tabelaTarefa.ObterIdSelecionado();

            Tarefa tarefaSelecionada = repositorioTarefa.SelecionarPorId(idSelecionado);

            if (SemSeleção(tarefaSelecionada)) return;

            TelaAtualizacaoDeItemTarefa tela = new(tarefaSelecionada);

            DialogResult resultado = tela.ShowDialog();

            if (resultado != DialogResult.OK) return;

            List<ItemTarefa> itensPendentes = tela.ItensPendentes;
            List<ItemTarefa> itensConcluidos = tela.ItensConcluidos;

            RealizaAcao(
                () => repositorioTarefa.AtualizarItens(tarefaSelecionada, itensPendentes, itensConcluidos),
                tarefaSelecionada, "atualizado");
        }

        public override UserControl ObterListagem()
        {
            tabelaTarefa ??= new TabelaTarefaControl();

            CarregarTarefas();
            return tabelaTarefa;
        }
        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();

            tabelaTarefa.AtualizarRegistros(tarefas);
        }
        private void CarregarMensagem(Tarefa tarefa, string texto)
        {
            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"O registro \"{tarefa.Titulo}\" foi {texto} com sucesso!");
        }
        private void RealizaAcao(Action acao, Tarefa tarefa, string texto)
        {
            acao();
            CarregarTarefas();
            CarregarMensagem(tarefa, texto);
        }

    }
}
