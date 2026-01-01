using Microsoft.Data.SqlClient; // biblioteca para SQL Server
using System;

namespace GVC.UTIL
{
    internal class Conexao
    {
        public static SqlConnection Conex()
        {
            try
            {
                // Nome do servidor: pode ser localhost\SQLEXPRESS ou WR-PC\SQLEXPRESS
                string serverName = @"localhost\SQLEXPRESS";

                // Nome do banco que você criou
                string databaseName = "bdsiscontrol";

                // Autenticação do Windows (integrada)
                string connString = $"Server={serverName};Database={databaseName};Trusted_Connection=True;Encrypt=False;";

                // Se quiser usar usuário e senha SQL:
                // string connString = $"Server={serverName};Database={databaseName};User Id=usuario;Password=senha;Encrypt=False;";

                return new SqlConnection(connString);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao banco SQL Server: " + ex.Message, ex);
            }
        }
    }
    public enum ModoVenda
    {
        Nova = 1,
        Edicao = 2
    }
}
