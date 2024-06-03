namespace eAgenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<T> where T : EntidadeBase
    {
        protected List<T> registros = new List<T>();
        protected int contadorId = 1;


        public void Cadastrar(T novoRegistro)
        {
            novoRegistro.Id = contadorId++;
            registros.Add(novoRegistro);
        }
        public void Editar(int id, T novaEntidade)
        {
            //novaEntidade.Id = id;
            SelecionarPorId(id).AtualizarRegistro(novaEntidade);
        }
        public void Excluir(int id) => registros.Remove(SelecionarPorId(id));
        
        
        public List<T> SelecionarTodos() => registros;
        public T SelecionarPorId(int id) => registros.Find(x => x.Id == id);
        public bool Existe(int id) => registros.Any(x => x.Id == id);
    }
}
