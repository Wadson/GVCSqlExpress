using GVC.DAL;
using GVC.DALL;
using GVC.MODEL;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GVC.BLL
{
    internal class FormaPgtoBLL
    {
        FormaPgtoDal formaPgtodal = null;
        

        public DataTable Listar()
        {
            DataTable dtable = new DataTable();
            try
            {
                formaPgtodal = new FormaPgtoDal();
                dtable = formaPgtodal.ListaFormaPgto();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            return dtable;
        }

        public void Salvar(FormaPgtoModel formaPgto)
        {
            try
            {
                formaPgtodal = new FormaPgtoDal();
                formaPgtodal.GravaFormaPgto(formaPgto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void Excluir(FormaPgtoModel formaPgto)
        {
            try
            {
                formaPgtodal = new FormaPgtoDal();
                formaPgtodal.ExcluiFormaPgto(formaPgto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public void Alterar(FormaPgtoModel formaPgto)
        {
            try
            {
                formaPgtodal = new FormaPgtoDal();
                formaPgtodal.Atualizar(formaPgto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        public FormaPgtoModel? BuscarPorId(int formaPgtoId)
        {
            formaPgtodal = new FormaPgtoDal();
            return formaPgtodal.BuscarPorId(formaPgtoId);
        }
        public FormaPgtoModel PesquisarNo(DataGridView DataGridPesquisa, string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM FormaPgto WHERE FormaPgto like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                FormaPgtoModel obj_formaPgto = new FormaPgtoModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_formaPgto.FormaPgtoID = Convert.ToInt32(datareader["FormaPgtoID"]);
                    obj_formaPgto.NomeFormaPgto = datareader["FormaPgto"].ToString();
                }
                return obj_formaPgto;
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
        public FormaPgtoModel PesquisarCodigo(string pesquisa)
        {
            var conn = Conexao.Conex();
            try
            {
                SqlCommand sql = new SqlCommand("SELECT * FROM FormaPgto WHERE FormaPgtoID like '" + pesquisa + "%'", conn);
                conn.Open();
                SqlDataReader datareader;
                FormaPgtoModel obj_formaPgto = new FormaPgtoModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);

                while (datareader.Read())
                {
                    obj_formaPgto.FormaPgtoID = Convert.ToInt32(datareader["FormaPgtoID"]);
                    obj_formaPgto.NomeFormaPgto = datareader["FormaPgto"].ToString();
                }
                return obj_formaPgto;
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
