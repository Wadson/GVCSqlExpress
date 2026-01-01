using GVC.MODEL;
using GVC.UTIL;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;

namespace GVC.DALL
{
    public class ItemVendaDal
    {
        // 1. ADICIONAR ITEM NA VENDA
        public void AddItemVenda(ItemVendaModel itemVenda)
        {
            string sql = @"
                INSERT INTO ItemVenda (
                    VendaID, ProdutoID, Quantidade, PrecoUnitario, Subtotal, DescontoItem
                )
                VALUES (
                    @VendaID, @ProdutoID, @Quantidade, @PrecoUnitario, @Subtotal, @DescontoItem
                )";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", itemVenda.VendaID);
            cmd.Parameters.AddWithValue("@ProdutoID", itemVenda.ProdutoID);
            cmd.Parameters.AddWithValue("@Quantidade", itemVenda.Quantidade);
            cmd.Parameters.AddWithValue("@PrecoUnitario", itemVenda.PrecoUnitario);
            cmd.Parameters.AddWithValue("@Subtotal", itemVenda.Subtotal);
            cmd.Parameters.AddWithValue("@DescontoItem", itemVenda.DescontoItem);
            cmd.ExecuteNonQuery();
        }

        // 2. ATUALIZAR ITEM DA VENDA
        public void UpdateItemVenda(ItemVendaModel itemVenda)
        {
            string sql = @"
                UPDATE ItemVenda
                SET ProdutoID = @ProdutoID,
                    Quantidade = @Quantidade,
                    PrecoUnitario = @PrecoUnitario,
                    Subtotal = @Subtotal,
                    DescontoItem = @DescontoItem
                WHERE ItemVendaID = @ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ItemVendaID", itemVenda.ItemVendaID);
            cmd.Parameters.AddWithValue("@ProdutoID", itemVenda.ProdutoID);
            cmd.Parameters.AddWithValue("@Quantidade", itemVenda.Quantidade);
            cmd.Parameters.AddWithValue("@PrecoUnitario", itemVenda.PrecoUnitario);
            cmd.Parameters.AddWithValue("@Subtotal", itemVenda.Subtotal);
            cmd.Parameters.AddWithValue("@DescontoItem", itemVenda.DescontoItem);
            cmd.ExecuteNonQuery();
        }

        // 3. EXCLUIR ITEM POR ID
        public void DeleteItemVenda(long itemVendaId)
        {
            string sql = "DELETE FROM ItemVenda WHERE ItemVendaID = @ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ItemVendaID", itemVendaId);
            cmd.ExecuteNonQuery();
        }

        public void Excluir(ItemVendaModel itemVenda) => DeleteItemVenda(itemVenda.ItemVendaID);

        // 4. LISTAR TODOS OS ITENS DE UMA VENDA
        public List<ItemVendaModel> ConsultarItensVenda(int vendaId)
        {
            string sql = @"
                SELECT ItemVendaID,
                       VendaID,
                       ProdutoID,
                       Quantidade,
                       PrecoUnitario,
                       Subtotal,
                       DescontoItem
                FROM ItemVenda
                WHERE VendaID = @VendaID
                ORDER BY ItemVendaID";

            var lista = new List<ItemVendaModel>();

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new ItemVendaModel
                {
                    ItemVendaID = reader.GetInt64("ItemVendaID"),
                    VendaID = reader.GetInt64("VendaID"),
                    ProdutoID = reader.GetInt64("ProdutoID"),
                    Quantidade = reader.GetInt32("Quantidade"),
                    PrecoUnitario = reader.GetDecimal("PrecoUnitario"),
                    Subtotal = reader.GetDecimal("Subtotal"),
                    DescontoItem = reader.GetDecimal("DescontoItem")
                });
            }
            return lista;
        }

        // 5. EXCLUIR TODOS OS ITENS DE UMA VENDA
        public void ExcluirItensPorVendaID(int vendaID)
        {
            string sql = "DELETE FROM ItemVenda WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaID);
            cmd.ExecuteNonQuery();
        }

        // 6. LISTAR TODOS OS ITENS (para relatórios)
        public DataTable ListarItensVenda()
        {
            string sql = "SELECT * FROM ItemVenda ORDER BY VendaID, ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        // 7. BUSCAR ITEM POR ID
        public ItemVendaModel? BuscarPorId(int itemVendaId)
        {
            string sql = "SELECT * FROM ItemVenda WHERE ItemVendaID = @Id";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Id", itemVendaId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new ItemVendaModel
                {
                    ItemVendaID = reader.GetInt64("ItemVendaID"),
                    VendaID = reader.GetInt64("VendaID"),
                    ProdutoID = reader.GetInt64("ProdutoID"),
                    Quantidade = reader.GetInt32("Quantidade"),
                    PrecoUnitario = reader.GetDecimal("PrecoUnitario"),
                    Subtotal = reader.GetDecimal("Subtotal"),
                    DescontoItem = reader.GetDecimal("DescontoItem")
                };
            }
            return null;
        }

        // 8. CALCULAR TOTAL DA VENDA
        public decimal CalcularTotalVenda(int vendaId)
        {
            string sql = @"
                SELECT ISNULL(SUM((Quantidade * PrecoUnitario) - ISNULL(DescontoItem, 0)), 0)
                FROM ItemVenda
                WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            return (decimal)cmd.ExecuteScalar();
        }

        // 9. LISTAR ITENS COM DADOS DO PRODUTO
        public DataTable ListarItensComProduto(int vendaId)
        {
            string sql = @"
                SELECT
                    iv.ItemVendaID,
                    iv.VendaID,
                    iv.ProdutoID,
                    p.NomeProduto AS ProdutoDescricao,
                    p.CodigoBarras,
                    iv.Quantidade,
                    iv.PrecoUnitario,
                    iv.Subtotal,
                    iv.DescontoItem,
                    (iv.Quantidade * iv.PrecoUnitario - ISNULL(iv.DescontoItem, 0)) AS TotalItem
                FROM ItemVenda iv
                INNER JOIN Produtos p ON iv.ProdutoID = p.ProdutoID
                WHERE iv.VendaID = @VendaID
                ORDER BY iv.ItemVendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            var dt = new DataTable();
            using var reader = cmd.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        // 10. LISTAR ITENS POR VENDA COM NOME DO PRODUTO
        public List<ItemVendaModel> ListarItensPorVenda(long vendaId)
        {
            string sql = @"
                SELECT
                    iv.ItemVendaID,
                    iv.VendaID,
                    iv.ProdutoID,
                    p.NomeProduto AS ProdutoDescricao,                   
                    iv.Quantidade,
                    iv.PrecoUnitario,
                    iv.Subtotal,
                    iv.DescontoItem,
                    (iv.Quantidade * iv.PrecoUnitario - ISNULL(iv.DescontoItem, 0)) AS TotalItem
                FROM ItemVenda iv
                INNER JOIN Produtos p ON iv.ProdutoID = p.ProdutoID
                WHERE iv.VendaID = @VendaID
                ORDER BY iv.ItemVendaID";           

            var itens = new List<ItemVendaModel>();

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var item = new ItemVendaModel
                {
                    // ⭐⭐ MUDAR DE GetInt64 PARA GetInt32 ⭐⭐
                    ItemVendaID = reader.GetInt32("ItemVendaID"),    // GetInt32
                    VendaID = reader.GetInt32("VendaID"),            // GetInt32
                    ProdutoID = reader.GetInt32("ProdutoID"),        // GetInt32
                    Quantidade = reader.GetInt32("Quantidade"),      // Já está GetInt32

                    PrecoUnitario = reader.GetDecimal("PrecoUnitario"),
                    Subtotal = reader.IsDBNull("Subtotal") ? null : reader.GetDecimal("Subtotal"),
                    DescontoItem = reader.IsDBNull("DescontoItem") ? null : reader.GetDecimal("DescontoItem"),
                    ProdutoDescricao = reader.IsDBNull("ProdutoDescricao") ? null : reader.GetString("ProdutoDescricao")
                };
                itens.Add(item);
            }
            return itens;      
        }

        public void ExcluirPorVenda(long vendaId)
        {
            string sql = "DELETE FROM ItemVenda WHERE VendaID = @VendaID";

            using var conn = Conexao.Conex();
            conn.Open();
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@VendaID", vendaId);
            cmd.ExecuteNonQuery();
        }
    }
}