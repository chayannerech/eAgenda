using eAgenda.WinApp.Compartilhado;
namespace eAgenda.WinApp.ModuloTarefa
{
    public class Tarefa(string titulo, PrioridadeTarefaEnum prioridade) : EntidadeBase
    {
        public string Titulo { get; set; } = titulo;
        public PrioridadeTarefaEnum Prioridade { get; set; } = prioridade;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataConclusao { get; set; } = DateTime.MinValue;
        public List<ItemTarefa> Itens { get; set; } = [];
        public decimal PercentualConcluido 
        {
            get 
            {
                if (Itens.Count == 0) return 0;

                decimal percentualBase = Itens.Count(i => i.Concluido)/ (decimal)Itens.Count;
                return Math.Round(percentualBase * 100, 2);
            } 
        }


        public void AdicionarItem (ItemTarefa item)
        {
            if (Itens.Exists(i => i.Titulo == item.Titulo)) return;

            item.Tarefa = this;

            Itens.Add(item);
            DataConclusao = DateTime.MinValue;
        }
        public void ConcluirItem(ItemTarefa item)
        {
            ItemTarefa itemTarefa = Itens.Find(i => i.Titulo == item.Titulo);

            if (itemTarefa == null) return;

            itemTarefa.Concluir();

            if (Itens.All(i => i.Concluido)) DataConclusao = DateTime.Now;
        }
        public void MarcarPendente(ItemTarefa item)
        {
            ItemTarefa itemTarefa = Itens.Find(i => i.Titulo == item.Titulo);

            if (itemTarefa == null) return;

            itemTarefa.MarcarPendente();
        }


        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tarefa atualizada = (Tarefa)novoRegistro;

            Titulo = atualizada.Titulo;
            Prioridade = atualizada.Prioridade;
        }
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();
            VerificaNulo(ref erros, Titulo, "título");
            return erros;
        }
        public override string ToString()
            => $"Id: {Id}, " +
               $"Título: {Titulo}, " +
               $"Prioridade: {Prioridade.ToString()}, " +
               $"Criada em: {DataCriacao.ToString(@"hh\:mm")}, ";
    }
}
