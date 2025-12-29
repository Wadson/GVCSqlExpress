using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class VendaCompletaModel
    {
        public int VendaID { get; set; }

        // ===== DATA DA VENDA =====
        public DateTime DataVenda { get; set; }

        public int ClienteID { get; set; }
        public string ClienteNome { get; set; }
        public string CpfCliente { get; set; }

        public decimal ValorTotal { get; set; }
        public decimal Desconto { get; set; }

        public int FormaPgtoID { get; set; }
        public string Observacoes { get; set; }

        // ===== LISTAS ===============
        public List<ItemVendaModel> Itens { get; set; }
        public List<ParcelaModel> Parcelas { get; set; }
        public int VendedorID { get; set; }
        public string VendedorNome { get; set; }
    }


}
