using System;
using Microsoft.Data.SqlClient;

namespace GVC.DAL
{
    public class PagamentosParciaisDal
    {
        public void ExcluirPorVenda(long vendaId)
        {
            string sql = @"
                DELETE FROM PagamentosParciais
                WHERE ParcelaID IN (
                    SELECT ParcelaID 
                    FROM Parcela 
                    WHERE VendaID = @VendaID
                )";

            using var conn = GVC.Helpers.Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }
    }
}
