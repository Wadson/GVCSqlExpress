using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GVC.View.FrmVendas;
using static GVC.View.FrmPDV;

namespace GVC.UTIL
{
    public static class StatusHelper
    {
        // VENDA
            public static string ToDb(this EnumStatusVenda status)
            => status switch
            {
                EnumStatusVenda.EmAnalise => "Em Análise",
                EnumStatusVenda.AguardandoPagamento => "Aguardando Pagamento",
                EnumStatusVenda.ParcialmentePago => "Parcialmente Pago",
                EnumStatusVenda.Concluida => "Concluída",
                _ => status.ToString()
            };

        // PARCELA
        public static string ToDb(this EnumStatusParcela status)
            => status switch
            {
                EnumStatusParcela.ParcialmentePaga => "Parcialmente Paga",
                _ => status.ToString()
            };


        // VENDA
        public static string ToDb(this EnumStatusVendaPDV status)
        => status switch
        {
            EnumStatusVendaPDV.EmAnalise => "Em Análise",
            EnumStatusVendaPDV.AguardandoPagamento => "Aguardando Pagamento",
            EnumStatusVendaPDV.ParcialmentePago => "Parcialmente Pago",
            EnumStatusVendaPDV.Concluida => "Concluída",
            _ => status.ToString()
        };

        // PARCELA
        public static string ToDb(this EnumStatusParcelaPDV status)
            => status switch
            {
                EnumStatusParcelaPDV.ParcialmentePaga => "Parcialmente Paga",
                _ => status.ToString()
            };

    }
}
