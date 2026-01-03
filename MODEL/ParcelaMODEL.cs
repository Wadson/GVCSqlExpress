using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GVC.MODEL.Enums;


namespace GVC.MODEL
{
    
    public class ParcelaModel
    {
        internal decimal Saldo;

        public int ParcelaID { get; set; }              // NOT NULL → int
        public int VendaID { get; set; }                // NOT NULL → int
        public int NumeroParcela { get; set; }          // NOT NULL → int
        public DateTime DataVencimento { get; set; }    // NOT NULL → DateTime
        public decimal ValorParcela { get; set; }       // NOT NULL → decimal(18,2)
        public decimal? ValorRecebido { get; set; }     // NULL → decimal?
        public EnumStatusParcela Status { get; set; }   // NOT NULL → string (nvarchar(20))
        public DateTime? DataPagamento { get; set; }    // NULL → DateTime?
        public decimal? Juros { get; set; }             // NULL → decimal?
        public decimal? Multa { get; set; }             // NULL → decimal?
        public string Observacao { get; set; }          // NULL → string (nvarchar(max))
      
    }

}
