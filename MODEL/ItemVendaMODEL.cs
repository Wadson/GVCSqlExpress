using System;
using System.ComponentModel;

namespace GVC.MODEL
{
    public class ItemVendaModel : INotifyPropertyChanged
    {
        private int quantidade = 1;
        private decimal precoUnitario;
        private decimal subtotal;
        private decimal descontoItem;

        public long ItemVendaID { get; set; }
        public long VendaID { get; set; }
        public long ProdutoID { get; set; }

        public decimal EstoqueAtual { get; set; }
        public string ProdutoDescricao { get; set; }

        public int Quantidade
        {
            get => quantidade;
            set
            {
                if (quantidade != value)
                {
                    quantidade = value;
                    OnPropertyChanged(nameof(Quantidade));
                    AtualizarSubtotal();
                }
            }
        }

        public decimal PrecoUnitario
        {
            get => precoUnitario;
            set
            {
                if (precoUnitario != value)
                {
                    precoUnitario = value;
                    OnPropertyChanged(nameof(PrecoUnitario));
                    AtualizarSubtotal();
                }
            }
        }

        public decimal DescontoItem
        {
            get => descontoItem;
            set
            {
                if (descontoItem != value)
                {
                    descontoItem = value;
                    OnPropertyChanged(nameof(DescontoItem));
                    AtualizarSubtotal();
                }
            }
        }

        public decimal Subtotal
        {
            get => subtotal;
            private set
            {
                if (subtotal != value)
                {
                    subtotal = value;
                    OnPropertyChanged(nameof(Subtotal));
                }
            }
        }

        public VendaModel Venda { get; set; }

        // Método para atualizar Subtotal sempre que Quantidade, PrecoUnitario ou DescontoItem mudar
        public void AtualizarSubtotal()
        {
            Subtotal = (Quantidade * PrecoUnitario) - DescontoItem;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
