namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromisso : Form
    {
        public TipoFiltroCompromissoEnum FiltroSelecionado { get; private set; }
        public TelaFiltroCompromisso()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (rdbTodosCompromissos.Checked) 
                FiltroSelecionado = TipoFiltroCompromissoEnum.Todos;
            
            else if (rdbCompromissosPassados.Checked)
                FiltroSelecionado = TipoFiltroCompromissoEnum.Passados;
            
            else if (rdbCompromissosFuturos.Checked)
                FiltroSelecionado = TipoFiltroCompromissoEnum.Futuros;
        }
    }

    public enum TipoFiltroCompromissoEnum
    {
        Todos,
        Passados,
        Futuros
    }
}
