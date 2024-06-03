namespace eAgenda.WinApp.ModuloContato
{
    public partial class ListagemContatosControl : UserControl
    {
        public ListagemContatosControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            listContatos.Items.Clear();

            foreach(Contato contato in contatos)
                listContatos.Items.Add(contato);
        }
        public Contato ObterRegistroSelecionado()
            => (Contato)listContatos.SelectedItem;
    }
}