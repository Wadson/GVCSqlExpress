using GVC.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    public class RelatorioGiroEstoqueBLL
    {
        public DataTable ObterGiro(DateTime inicio, DateTime fim)
        {
            return new RelatorioGiroEstoqueDAL().ObterGiro(inicio, fim);
        }
    }
}
