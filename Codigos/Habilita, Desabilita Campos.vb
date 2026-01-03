Fluxo Corrigido e Completo Desejado

1-Ao abrir o Form Venda (modo Novo)
Todos os campos e botões desabilitados
Apenas txtClienteBuscar.Enabled = true e recebe foco
btnSair.Enabled = true

2-Após selecionar Cliente → ClienteID > 0
Habilita txtVendedorBuscar
Coloca foco nele
Mantém txtClienteBuscar habilitado (para permitir troca de cliente se necessário)

3-Após selecionar Vendedor → VendedorID > 0
Habilita txtProdutoBuscar
Coloca foco nele

4-Após adicionar pelo menos 1 item no dgvItensVenda
Habilita dgvItensVenda (para edição/exclusão)
Habilita btnFinalizarVenda (ou F12 para abrir finalização)

5-Ao pressionar F12 → abre FrmFinalizacaoVenda
Após fechar esse form com sucesso (DialogResult.OK), considera a venda pronta
Habilita btnNovaVenda (para iniciar nova)
Mantém btnFinalizarVenda habilitado se quiser refinalizar

6-Após salvar a venda (Finalizada)
Bloqueia tudo exceto btnNovaVenda e btnSair



FORMULÁRIO FrmFinalizacaoVenda ////////////////////////////////////////////////////

No Load do FrmFinalizacaoVenda já iniciar com os componentes bloqueados 
menos o cmbFormaPagamento que deve estar com .Enble = true
> Ao Escolher a Forma de Pagamento > Habilitar os controles conforme a forma de pagamento:

Se a forma de Pagamento for = Dinheiro, PIX, Transferência ou Cartão de Débito >
então automaticamente gerar uma uma parcela com DataPagamento atual.

Se a forma de pagamento for = Cartão de Crédito, Boleto, Cheque ou Crediário>
então habilitar:
txtValorRecebido.Enabled = true        
NumeroParcela.Enabled = true
DataPagamento.Enabled = true
numIntervalo.Enabled = true
btnGerarParcelas.Enabled = true













