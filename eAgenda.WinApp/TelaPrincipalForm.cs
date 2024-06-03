using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloCompromisso;
using eAgenda.WinApp.ModuloContato;
using eAgenda.WinApp.ModuloTarefa;
namespace eAgenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        ControladorBase controlador;
        RepositorioContato repositorioContato;
        RepositorioCompromisso repositorioCompromisso;
        RepositorioTarefa repositorioTarefa;
        public static TelaPrincipalForm Instancia { get; private set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            lblTipoCadastro.Text = string.Empty;

            repositorioContato = new();
            repositorioCompromisso = new();
            repositorioTarefa = new();

            Instancia = this;
        }

        public void AtualizarRodape(string texto)
            => StatusLabelPrincipal.Text = texto;

        private void contatosMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorContato(repositorioContato));

        private void compromissosMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato));

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorTarefa(repositorioTarefa));

        private void btnAdicionar_Click(object sender, EventArgs e)
            => controlador.Adicionar();

        private void btnEditar_Click(object sender, EventArgs e)
            => controlador.Editar();

        private void btnExcluir_Click(object sender, EventArgs e)
            => controlador.Excluir();

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorFiltravel controladorFiltravel)
                controladorFiltravel.Filtrar();
        }

        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorSubItens controladorSubItens)
                controladorSubItens.AdicionarItens();
        }

        private void btnConcluirItens_Click(object sender, EventArgs e)
        {
            if (controlador is IControladorSubItens controladorSubItens)
                controladorSubItens.AtualizarItens();
        }


        private void SelecionaModulo(ref ControladorBase controlador, Action controladorSelecionado)
        {
            controladorSelecionado();
            lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;
            ConfigurarToolBox(controlador);
            ConfigurarListagem(controlador);
        }
        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;

            if (controladorSelecionado is IControladorFiltravel controladorFiltravel)
                btnFiltrar.ToolTipText = controladorFiltravel.ToolTipFiltrar;

            if (controlador is IControladorSubItens controladorSubItens)
            {
                btnAdicionarItens.ToolTipText = controladorSubItens.ToolTipAdicionarItens;
                btnConcluirItens.ToolTipText = controladorSubItens.ToolTipConcluirItens;
            }
        }
        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
            UserControl listagemContato = controladorSelecionado.ObterListagem();
            listagemContato.Dock = DockStyle.Fill;

            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
        }
        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnFiltrar.Enabled = controladorSelecionado is IControladorFiltravel;
            btnAdicionarItens.Enabled = controladorSelecionado is IControladorSubItens;
            btnConcluirItens.Enabled = controladorSelecionado is IControladorSubItens;
            ConfigurarToolTips(controladorSelecionado);
        }
    }
}
