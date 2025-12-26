using GVC.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    public class RelatorioEstoqueBLL
    {
        private readonly RelatorioEstoqueDAL dal = new();

        public DataTable ObterRelatorioEstoque(
            out decimal totalCusto,
            out decimal totalVenda,
            out decimal totalLucro)
        {
            var dt = dal.ObterRelatorioEstoque();

            totalCusto = 0m;
            totalVenda = 0m;
            totalLucro = 0m;

            foreach (DataRow row in dt.Rows)
            {
                totalCusto += Convert.ToDecimal(row["ValorTotalCusto"]);
                totalVenda += Convert.ToDecimal(row["ValorTotalVenda"]);
                totalLucro += Convert.ToDecimal(row["LucroTotalProduto"]);
            }

            return dt;
        }
    }

}
