using eAgenda.WinApp.Compartilhado;
namespace eAgenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public List<Compromisso> SelecionarCompromissosPassados()
            => registros
                .FindAll(compromisso => compromisso.Data < DateTime.Today);

        public List<Compromisso> SelecionarCompromissosFuturos()
            => registros
                .FindAll(compromisso => compromisso.Data >= DateTime.Today);

        public List<Compromisso> SelecionarCompromissosPorPeriodo(DateTime dataInicio, DateTime dataTermino)
            => registros
                .FindAll(compromisso => compromisso.Data >= dataInicio && compromisso.Data <= dataTermino);
    }
}
