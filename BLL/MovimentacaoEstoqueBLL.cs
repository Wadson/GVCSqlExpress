using GVC.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    public class MovimentacaoEstoqueBLL
    {
        private readonly MovimentacaoEstoqueDAL dal = new();

        public DataTable ConsultarMovimentacoes(
            int? produtoId,
            string tipo,
            string origem,
            DateTime inicio,
            DateTime fim)
        {
            return dal.Consultar(produtoId, tipo, origem, inicio, fim);
        }
    }

}
