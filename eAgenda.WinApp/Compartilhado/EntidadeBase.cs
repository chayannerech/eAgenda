using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace eAgenda.WinApp.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }

        public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
        public abstract List<string> Validar();


        protected void VerificaNulo(ref List<string> erros, string campoTestado, string mostraCampo)
        {
            if (string.IsNullOrEmpty(campoTestado))
                erros.Add($"\nO campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
        }
        protected void VerificaNulo(ref List<string> erros, int campoTestado, string mostraCampo)
        {
            if (string.IsNullOrEmpty(campoTestado.ToString()))
                erros.Add($"\nO campo \"{mostraCampo}\" é obrigatório. Tente novamente ");
        }
        protected void VerificaNulo(ref List<string> erros, string campoTestado1, string campoTestado2, string mostraCampo1, string mostraCampo2)
        {
            if (string.IsNullOrEmpty(campoTestado1) && string.IsNullOrEmpty(campoTestado2))
                erros.Add($"\nO campo \"{mostraCampo1}/{mostraCampo2}\" é obrigatório. Tente novamente ");
        }
    }
}
