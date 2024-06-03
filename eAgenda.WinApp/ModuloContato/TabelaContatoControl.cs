using eAgenda.WinApp.Compartilhado;
namespace eAgenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
        }

        internal void AtualizarRegistros(List<Contato> contatos)
        {
            grid.Rows.Clear();

            foreach (Contato contato in contatos)
                grid.Rows.Add(contato.Id, contato.Nome.ToTitleCase(), contato.Telefone, contato.Email, contato.Empresa, contato.Cargo);
        }

        public int ObterRegistroSelecionado()
            => grid.SelecionarId();
    }
}
