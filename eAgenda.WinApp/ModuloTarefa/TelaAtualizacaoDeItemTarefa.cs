namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizacaoDeItemTarefa : Form
    {
        public List<ItemTarefa> ItensPendentes
        {
            get => listItensTarefa.Items
                .Cast<ItemTarefa>()
                .Except(ItensConcluidos)
                .ToList();
        }
        public List<ItemTarefa> ItensConcluidos 
        { 
            get => listItensTarefa.CheckedItems
                .Cast<ItemTarefa>().ToList();
        }

        public TelaAtualizacaoDeItemTarefa(Tarefa tarefaSelecionada)
        {
            InitializeComponent();

            labelTituloTarefa.Text = tarefaSelecionada.Titulo;

            CarregarItensSelecionados(tarefaSelecionada);
        }
        
        private void btnGravar_Click(object sender, EventArgs e)
        {

        }

        private void CarregarItensSelecionados(Tarefa tarefaSelecionada)
        {
            int i = 0;

            foreach (ItemTarefa item in tarefaSelecionada.Itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.Concluido) listItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }
    }
}
