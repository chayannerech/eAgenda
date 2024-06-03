using eAgenda.WinApp.Compartilhado;
using eAgenda.WinApp.ModuloContato;
namespace eAgenda.WinApp.ModuloCompromisso
{
    public class Compromisso (string assunto, DateTime data, TimeSpan inicio, TimeSpan termino, Contato contato, string local, string link) : EntidadeBase
    {
        public string Assunto { get; set; } = assunto;
        public DateTime Data { get; set; } = data;
        public TimeSpan Inicio { get; set; } = inicio;
        public TimeSpan Termino { get; set; } = termino;
        public Contato Contato { get; set; } = contato;
        public string Local { get; set; } = local;
        public string Link { get; set; } = link;
        public TipoCompromissoEnum tipoCompromisso
        { 
            get
            {
                TipoCompromissoEnum tipoSelecionado;
                
                if (Local.Length > 0) tipoSelecionado = TipoCompromissoEnum.Presencial;
                else tipoSelecionado = TipoCompromissoEnum.Remoto;
                
                return tipoSelecionado;
            }
        }


        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Compromisso atualizado = (Compromisso)novoRegistro;

            Assunto = atualizado.Assunto;
            Data = atualizado.Data;
            Inicio = atualizado.Inicio;
            Termino = atualizado.Termino;
            Contato = atualizado.Contato;
            Local = atualizado.Local;
        }
        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            VerificaNulo(ref erros, Assunto, "assunto");
            VerificaNulo(ref erros, Local, Link, "local", "link");
            if (Inicio > Termino) erros.Add("O horário de término precisa ser após o horário de início");

            return erros;
        }
        public override string ToString()
        {
            string nomeContato = Contato == null ? string.Empty : Contato.Nome;

            return $"Id: {Id}, " +
                   $"Assunto: {Assunto}, " +
                   $"Data: {Data.ToString("d")}, " +
                   $"Início: {Inicio.ToString(@"hh\:mm")}, " +
                   $"Término: {Termino.ToString(@"hh\:mm")}, " +
                   $"Contato: {nomeContato}" +
                   $"Endereço: {Local}";
        }
    }
}
