using GVC.MODEL;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.DAL
{
    internal class FormaPgtoDal
    {
        private const string SqlBase = @"
            SELECT FormaPgtoID, FormaPgto FROM FormaPgto";
        public DataTable ListaFormaPgto()
        {
            var conn = Conexao.Conex();
            try
            {
                var comando = new SqlCommand("SELECT FormaPgtoID, FormaPgto FROM FormaPgto", conn);

                conn.Open();
                var reader = comando.ExecuteReader();

                var dtFormaPgto = new DataTable();
                dtFormaPgto.Load(reader);
                return dtFormaPgto;
            }
            finally
            {
                conn.Close();
            }
        }

        public void GravaFormaPgto(FormaPgtoModel formaPgtos)
        {
            var conn = Conexao.Conex();
            try
            {
                var sqlcomm = new SqlCommand("INSERT INTO FormaPgto (FormaPgto) VALUES (@FormaPgto)", conn);

                sqlcomm.Parameters.AddWithValue("@FormaPgto", formaPgtos.NomeFormaPgto);
                conn.Open();
                sqlcomm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void ExcluiFormaPgto(FormaPgtoModel formaPgto)
        {
            var conn = Conexao.Conex();
            try
            {
                var sqlcomando = new SqlCommand("DELETE FROM FormaPgto WHERE FormaPgtoID = @FormaPgtoID", conn);
                sqlcomando.Parameters.AddWithValue("@FormaPgtoID", formaPgto.FormaPgtoID);

                conn.Open();
                sqlcomando.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void Atualizar(FormaPgtoModel formaPgto)
        {
            var conn = Conexao.Conex();
            try
            {
                var sqlcomm = new SqlCommand("UPDATE FormaPgto SET FormaPgto = @NomeFormaPgto WHERE FormaPgtoID = @FormaPgtoID", conn);

                sqlcomm.Parameters.AddWithValue("@NomeFormaPgto", formaPgto.NomeFormaPgto);               
                sqlcomm.Parameters.AddWithValue("@FormaPgtoID", formaPgto.FormaPgtoID);

                conn.Open();
                sqlcomm.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable PesquisarPorNome(string nome)
        {
            var conn = Conexao.Conex();
            try
            {
                var sqlconn = "SELECT FormaPgtoID, FormaPgto FROM FormaPgto WHERE FormaPgto LIKE @NomeFormaPgto";
                var cmd = new SqlCommand(sqlconn, conn);
                cmd.Parameters.AddWithValue("@NomeFormaPgto", "%" + nome + "%");

                conn.Open();
                var reader = cmd.ExecuteReader();

                var dt = new DataTable();
                dt.Load(reader);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public FormaPgtoModel? BuscarPorId(int formaPgtoID)
        {
            string sql = SqlBase + " WHERE FormaPgtoID = @Id";
            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", formaPgtoID);
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapFormaPgto(reader);
                    }
                }
            }
            return null;
        }
        public DataTable PesquisarPorCodigo(int nome)
        {
            var conn = Conexao.Conex();
            try
            {
                DataTable dt = new DataTable();

                string sqlconn = "SELECT FormaPgtoID, FormaPgto FROM FormaPgto WHERE FormaPgtoID = @FormaPgtoID";

                using (SqlCommand cmd = new SqlCommand(sqlconn, conn))
                {
                    cmd.Parameters.AddWithValue("@FormaPgtoID", Convert.ToInt32(nome));

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a pesquisa: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Dispose();
            }
        }
        // Método auxiliar para mapear EmpresaModel a partir de SqlDataReader
        private FormaPgtoModel MapFormaPgto(SqlDataReader reader)
        {
            return new FormaPgtoModel
            {
                FormaPgtoID = reader.GetInt32(reader.GetOrdinal("FormaPgtoID")),
                NomeFormaPgto = reader["FormaPgto"]?.ToString() ?? "",              
            };
        }
    }
}
