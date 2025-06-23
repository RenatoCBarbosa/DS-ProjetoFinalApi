using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoFinalApi.Locacao.Enuns;

namespace ProjetoFinalApi.Locacao.Models
{
    public class LocacaoApi
    {

        public string Nome { get; set; }
         public int Id { get; set; } //IdLocacao
         public int IdUsuario { get; set; }
         public int IdPropostaLocador { get; set; }
         public int Classe { get; set; }
         public int IdLocador { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public ValorEnum Valor { get; set; }
        public char Situacao { get; set; }
        public DateTime DtSituacao { get; set; }
        public int IdUsuarioSituacao { get; set; }
    }
}