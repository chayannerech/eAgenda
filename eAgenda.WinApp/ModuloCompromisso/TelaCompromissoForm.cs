using eAgenda.WinApp.ModuloContato;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        public TelaCompromissoForm()
        {
            InitializeComponent();
        }
        public void CarregarContatos(List<Contato> contatos)
        {
            cmbContatos.Items.Clear();
            foreach (Contato contato in contatos)
                cmbContatos.Items.Add(contato);
        }

        private Compromisso compromisso;
        public Compromisso Compromisso
        {
            get => compromisso;
            set
            {
                txtId.Text = value.Id.ToString();
                txtAssunto.Text = value.Assunto;
                dtpData.Text = value.Data.ToString();
                dtpInicio.Text = value.Inicio.ToString();
                dtpTermino.Text = value.Termino.ToString();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)

        {
            string assunto = txtAssunto.Text;
            DateTime data = dtpData.Value;
            TimeSpan inicio = dtpInicio.Value.TimeOfDay;
            TimeSpan termino = dtpTermino.Value.TimeOfDay;
            Contato contato = (Contato)cmbContatos.SelectedItem;

            string local = txtLocal.Text;
            string link = txtLink.Text;

            compromisso = new Compromisso(assunto, data, inicio, termino, contato, local, link);
            
            List<string> erros = compromisso.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
        private void checkMarcarContato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMarcarContato.Checked)
                cmbContatos.Enabled = true;
            else
            {
                cmbContatos.SelectedItem = null;
                cmbContatos.Enabled = false;
            }
        }
        private void rdbPresencial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPresencial.Checked)
            {
                txtLink.Text = string.Empty;
                txtLink.Enabled = false;
            }
            else txtLink.Enabled = true;
        }
        private void rdbRemoto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRemoto.Checked)
            {
                txtLocal.Text = string.Empty;
                txtLocal.Enabled = false;
            }
            else txtLocal.Enabled = true;
        }
    }
}
