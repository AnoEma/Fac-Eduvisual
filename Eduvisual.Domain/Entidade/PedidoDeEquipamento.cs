using System;

namespace Eduvisual.Domain
{
    public class PedidoDeEquipamento
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public TipoUso TipoUso { get; set; }
        public EquipamentoDeInformatica Equipamento { get; set; }
        public DateTime DataPrevistoDeUso { get; set; }
        public DateTime DataPrevistoDeDevolver { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataDeEntegrarPedido { get; set; }
        public DateTime DataDeDevolucaoPedido { get; set; }
    }
}