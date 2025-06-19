using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinalApi.Locacao.Models
{
    public class LocacaoApi
    {
         public int IdLocacao { get; set; }

         public int IdUsuario { get; set; }

         public int IdPropostaLocador { get; set; }

         public int IdLocador { get; set; }

        public string DtInicio { get; set; }

        public string DtFim { get; set; }

        public ValorEnum Valor { get; set; }

        public char Situacao { get; set; }

        public string DtSituacao { get; set; }

        public int IdUsuarioSituacao { get; set; }

    }
}