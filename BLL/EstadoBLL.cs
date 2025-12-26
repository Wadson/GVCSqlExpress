using GVC.DALL;
using GVC.MODEL;
using System;
using Microsoft.Data.SqlClient;
using System.Data;

namespace GVC.BLL
{
    internal class EstadoBLL
    {
        EstadoDal estadoDal = null;

        public DataTable Listar()
        {
            try
            {
                estadoDal = new EstadoDal();
                return estadoDal.Listar();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Salvar(EstadoMODEL estado)
        {
            try
            {
                estadoDal = new EstadoDal();
                estadoDal.Salvar(estado);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(EstadoMODEL estado)
        {
            try
            {
                estadoDal = new EstadoDal();
                estadoDal.Excluir(estado);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Atualizar(EstadoMODEL estado)
        {
            try
            {
                estadoDal = new EstadoDal();
                estadoDal.Atualizar(estado);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public EstadoMODEL Pesquisar(string pesquisa)
        {
            using var conn = GVC.Helpers.Conexao.Conex();
            try
            {
                var sql = new SqlCommand(
                    "SELECT TOP 1 EstadoID, CodigoUf, Nome, Uf FROM Estado WHERE Nome LIKE @Nome", conn);
                sql.Parameters.AddWithValue("@Nome", pesquisa + "%");  // ✅ parâmetro seguro

                conn.Open();
                var datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                EstadoMODEL obj_estado = null;
                if (datareader.Read())
                {
                    obj_estado = new EstadoMODEL
                    {
                        EstadoID = Convert.ToInt32(datareader["EstadoID"]),
                        Nome = datareader["Nome"].ToString(),
                        UF = datareader["Uf"].ToString()
                    };
                }
                return obj_estado;
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
