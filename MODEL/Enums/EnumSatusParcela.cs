using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.MODEL.Enums
{
    public enum EnumStatusParcela
    {
        Pendente,
        ParcialmentePago,
        Pago,
        Atrasada,        
        Cancelada    
        
    }

    public enum EnumStatusVenda
    {
        Aberta,
        AguardandoPagamento,
        ParcialmentePago,
        Concluida,
        Cancelada, 
        Suspensa
    }


}
