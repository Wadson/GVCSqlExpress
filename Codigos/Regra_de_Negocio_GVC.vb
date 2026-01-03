Tenho todas as tabelas mais aqui está as principais para a venda

TABLE [dbo].[Venda](
	[VendaID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NOT NULL,
	[FormaPgtoID] [int] NULL,
	[DataVenda] [datetime2](7) NOT NULL,
	[ValorTotal] [decimal](18, 2) NOT NULL,
	[Desconto] [decimal](18, 2) NOT NULL,
	[Observacoes] [nvarchar](max) NULL,
	[StatusVenda] [nvarchar](20) NOT NULL,
	[VendedorID] [int] NULL,
CONSTRAINT [PK_Venda] PRIMARY KEY CLUSTERED 


TABLE [dbo].[ItemVenda](
	[ItemVendaID] [int] IDENTITY(1,1) NOT NULL,
	[VendaID] [int] NOT NULL,
	[ProdutoID] [int] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[PrecoUnitario] [decimal](18, 2) NOT NULL,
	[Subtotal] [decimal](18, 2) NOT NULL,
	[DescontoItem] [decimal](18, 2) NULL,
 CONSTRAINT [PK_ItemVenda] PRIMARY KEY CLUSTERED 

 TABLE [dbo].[Parcela](
	[ParcelaID] [int] IDENTITY(1,1) NOT NULL,
	[VendaID] [int] NOT NULL,
	[NumeroParcela] [int] NOT NULL,
	[DataVencimento] [date] NOT NULL,
	[ValorParcela] [decimal](18, 2) NOT NULL,
	[ValorRecebido] [decimal](18, 2) NULL,
	[Status] [nvarchar](20) NOT NULL,
	[DataPagamento] [date] NULL,
	[Juros] [decimal](18, 2) NULL,
	[Multa] [decimal](18, 2) NULL,
	[Observacao] [nvarchar](max) NULL,
 CONSTRAINT [PK_Parcela] PRIMARY KEY CLUSTERED 

TABLE [dbo].[PagamentosParciais](
	[PagamentoID] [int] IDENTITY(1,1) NOT NULL,
	[ParcelaID] [int] NOT NULL,
	[ValorPago] [decimal](18, 2) NOT NULL,
	[DataPagamento] [date] NOT NULL,
	[FormaPgtoID] [int] NULL,
	[Observacao] [nvarchar](max) NULL,
 CONSTRAINT [PK_PagamentosParciais] PRIMARY KEY CLUSTERED 

TABLE [dbo].[FormaPagamento](
	[FormaPgtoID] [int] IDENTITY(1,1) NOT NULL,
	[NomeFormaPagamento] [nvarchar](50) NOT NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_FormaPgto] PRIMARY KEY CLUSTERED 

REGRAS DE NEGÓCIO DO SISTEMA GVC

🔄 Fluxo completo com formas de pagamento
1. Venda à vista (Dinheiro, Débito, PIX, Transferência)
Venda: criada com StatusVenda = 'Concluída' se o pagamento é imediato.
ItemVenda: todos os produtos/serviços.
Parcela: uma única parcela com Status = 'Paga' e DataPagamento = DataVenda.
PagamentosParciais: registro único com o valor total pago.

👉 Exemplo:

FormaPgto = Dinheiro
Venda → Concluída
Parcela → Paga
Pagamento → único, valor total.

2. Venda com Cartão de Crédito

Venda: criada com StatusVenda = 'Aguardando Pagamento' até confirmação da operadora.
ItemVenda: produtos/serviços.
Parcela:
Se parcelado: gera N parcelas com Status = 'Pendente'.
Se à vista no crédito: gera 1 parcela Pendente.
PagamentosParciais:
Quando a operadora confirma, grava pagamento.
Parcela(s) passam para Paga ou Parcialmente Paga.
Venda: muda para Concluída quando todas as parcelas estão quitadas.

👉 Exemplo:

FormaPgto = Cartão de Crédito (3x)
Venda → Aguardando Pagamento
Parcelas → 3 registros Pendente
Conforme liquidação → Parcialmente Pago → Concluída.

3. Venda com Boleto

Venda: criada com StatusVenda = 'Aguardando Pagamento'.
ItemVenda: produtos/serviços.
Parcela:
Uma parcela com vencimento futuro (Status = 'Pendente').
PagamentosParciais:
Quando o cliente paga o boleto, registra pagamento.
Parcela → Paga.
Venda: muda para Concluída.

👉 Exemplo:

FormaPgto = Boleto
Venda → Aguardando Pagamento
Parcela → Pendente até liquidação
Pagamento → único, valor total.

4. Venda com Cheque

Venda: criada com StatusVenda = 'Em Análise' ou Aguardando Pagamento (aguarda compensação).
ItemVenda: produtos/serviços.
Parcela:
Uma parcela com vencimento na data do cheque.
PagamentosParciais:
Quando o cheque compensa, registra pagamento.
Parcela → Paga.
Venda: muda para Concluída.

👉 Exemplo:

FormaPgto = Cheque
Venda → Em Análise
Parcela → Pendente
Após compensação → Paga → Venda Concluída.

📊 StatusVenda (Tabela Venda)
Aberta               → em edição.
EmAnálise           → aguardando aprovação (crédito/cheque).
Aguardando Pagamento → emitida, aguardando liquidação.
Parcialmente Pago    → parte quitada.
Concluída            → 100% liquidada.
Cancelada            → anulada.
Suspensa             → bloqueada temporariamente.

📊 Status (Tabela Parcela)
Pendente          → aguardando pagamento.
ParcialmentePago → recebeu parte.
Pago              → liquidada.
Atrasada          → vencida sem quitação.
Cancelada         → anulada.


🔎 Resumindo o fluxo por forma de pagamento
Forma de Pagamento,Status Venda Inicial,Parcelas Geradas,Status Parcela Inicial,Status Final (Liquidação)
Dinheiro,Concluída,1,Paga,Concluída
Débito,Concluída,1,Paga,Concluída
PIX,Concluída,1,Paga,Concluída
Transferência,Concluída,1,Paga,Concluída
Cartão Crédito,Aguardando Pagamento,1 ou N,Pendente,Concluída (após quitação)
Boleto,Aguardando Pagamento,1,Pendente,Concluída (após quitação)
Cheque,Em Análise,1,Pendente,Concluída (após compensar)
Crediário,Aguardando Pagamento,N,Pendente,Concluída (após quitação)


👉 Esse é o fluxo do sistema GVC:

À vista (Dinheiro, Débito, PIX, Transferência) → Venda já nasce Concluída.
Crédito, Boleto, Cheque, Crediário → Venda nasce Aguardando Pagamento ou Em Análise, 
e só vira Concluída após quitação das parcelas.
