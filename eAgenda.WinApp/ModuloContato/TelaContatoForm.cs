namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaCompromissoForm : Form
    {
        private Contato contato;
        public Contato Contato
        {
            get => contato;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
                txtTelefone.Text = value.Telefone;
                txtEmail.Text = value.Email;
                txtCargo.Text = value.Cargo;
                txtEmpresa.Text = value.Empresa;
            }
        }

        public TelaCompromissoForm()
        {
            InitializeComponent();
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            string email = txtEmail.Text;
            string cargo = txtCargo.Text;
            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, telefone, email, empresa, cargo);
            List<string> erros = contato.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
