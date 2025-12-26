using GVC.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    public class RelatorioLucroProdutoBLL
    {
        public DataTable ObterRanking()
        {
            return new RelatorioLucroProdutoDAL().RankingLucro();
        }
    }
}
