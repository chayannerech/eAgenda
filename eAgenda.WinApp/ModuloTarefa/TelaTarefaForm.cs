using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        public Tarefa Tarefa 
        { 
            get => tarefa; 
            set 
            { 
                txtId.Text = value.Id.ToString();
                txtTitulo.Text = value.Titulo;
                cmbPrioridades.SelectedItem = value.Prioridade;
            }
        }
        public TelaTarefaForm()
        {
            InitializeComponent();
            CarregarPrioridades();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            PrioridadeTarefaEnum prioridade = (PrioridadeTarefaEnum)cmbPrioridades.SelectedItem;

            tarefa = new Tarefa(titulo, prioridade);

            ValidacaoDeCampos(tarefa);
        }

        private void CarregarPrioridades()
        {
            Array valoresEnum = Enum.GetValues(typeof(PrioridadeTarefaEnum));

            foreach (var nome in valoresEnum)
                cmbPrioridades.Items.Add(nome);

            cmbPrioridades.SelectedItem = PrioridadeTarefaEnum.Baixa;
        }
        private void ValidacaoDeCampos(EntidadeBase entidade)
        {
            List<string> erros = entidade.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
