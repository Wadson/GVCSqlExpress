using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL
{
    public class MovimentacaoEstoqueModel
    {
        public int MovimentacaoID { get; set; }
        public int ProdutoID { get; set; }
        public string TipoMovimentacao { get; set; } // Entrada | Saida | Ajuste
        public int Quantidade { get; set; }
        public int EstoqueAnterior { get; set; }
        public int EstoqueAtual { get; set; }
        public string Origem { get; set; }
        public string Documento { get; set; }
        public string Observacao { get; set; }
        public DateTime DataMovimentacao { get; set; }
        public string Usuario { get; set; }
    }

}
