using System;
using System.Collections.Generic;
using System.Text;

namespace GVC.MODEL
{
    internal class FormaPagamentoModel
    {
        public int FormaPgtoID { get; set; }              // corresponde ao campo [FormaPgtoID] (int)
        public string NomeFormaPagamento { get; set; }    // corresponde ao campo [NomeFormaPagamento] (nvarchar)
        public bool Ativo { get; set; }                   // corresponde ao campo [Ativo] (bit)
    }

}
