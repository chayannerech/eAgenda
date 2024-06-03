using eAgenda.WinApp.Compartilhado;
namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        internal void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();

            foreach (Compromisso compromisso in compromissos)
                grid.Rows.Add(
                    compromisso.Id, 
                    compromisso.Assunto, 
                    compromisso.Data, 
                    compromisso.Inicio, 
                    compromisso.Termino, 
                    compromisso.Contato );
        }

        public int ObterRegistroSelecionado()
            => grid.SelecionarId();

        private static DataGridViewColumn[] ObterColunas()
        {
            return [
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Assunto", HeaderText = "Assunto" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Inicio", HeaderText = "Início" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Termino", HeaderText = "Término" },
                new DataGridViewTextBoxColumn { DataPropertyName = "Contato", HeaderText = "Contato" },
            ];
        }
    }
}
