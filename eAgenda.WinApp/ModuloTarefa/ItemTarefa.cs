namespace eAgenda.WinApp.ModuloTarefa
{
    public class ItemTarefa (string titulo)
    {
        public string Id { get; set; }
        public string Titulo { get; set; } = titulo;
        public bool Concluido { get; set; }
        public Tarefa Tarefa { get; set; }

        public void Concluir() => Concluido = true;
        public void MarcarPendente() => Concluido = false;
        public override string ToString() => $"{Titulo}";
    }
}
