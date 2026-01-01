using GVC.DALL;
using GVC.MODEL;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using GVC.UTIL;

namespace GVC.BLL
{
    internal class UsuarioBLL
    {
        UsuarioDal usuariodal = null;

        public string ObterSenhaHashPorId(int usuarioId)
        {
            string sql = "SELECT Senha FROM Usuarios WHERE UsuarioID = @id";

            using (var conn = Conexao.Conex())
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@id", usuarioId);

                conn.Open();
                object result = cmd.ExecuteScalar();
                return result?.ToString(); // retorna a senha como string
            }

        }
        public DataTable Listar()
        {
            DataTable dtable = new DataTable();
            try
            {
                usuariodal = new UsuarioDal();
                dtable = usuariodal.ListaUsuario();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void Salvar(UsuarioMODEL usuarios)
        {
            try
            {
                usuariodal = new UsuarioDal();
                usuariodal.GravaUsuario(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(UsuarioMODEL usuarios)
        {
            try
            {
                usuariodal = new UsuarioDal();
                usuariodal.ExcluiUsuario(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void Alterar(UsuarioMODEL usuarios)
        {
            try
            {
                usuariodal = new UsuarioDal();
                usuariodal.Atualizar(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void AtualizaUsuarioDalSenha(UsuarioMODEL usuarios)
        {
            try
            {
                usuariodal = new UsuarioDal();
                usuariodal.AtualizaUsuarioSenha(usuarios);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
      
        public UsuarioMODEL PesquisarNo(DataGridView DataGridPesquisa, string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM Usuarios WHERE NomeUsuario like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                UsuarioMODEL obj_usuario = new UsuarioMODEL();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_usuario.UsuarioID = Convert.ToInt32(datareader["UsuarioID"]);
                    obj_usuario.NomeUsuario = datareader["NomeUsuario"].ToString();
                }
                return obj_usuario;
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
        public UsuarioMODEL PesquisarCodigo(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM Usuarios WHERE UsuarioID like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                UsuarioMODEL obj_usuario = new UsuarioMODEL();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_usuario.UsuarioID = Convert.ToInt32(datareader["UsuarioID"]);
                    obj_usuario.NomeUsuario = datareader["NomeUsuario"].ToString();
                }
                return obj_usuario;
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
