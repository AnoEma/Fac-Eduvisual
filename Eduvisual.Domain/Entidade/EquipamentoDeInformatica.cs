using System;

namespace Eduvisual.Domain
{
    public class EquipamentoDeInformatica
    {
        public int Id { get; set; }
        public string TipoEquipamento { get; set; }
        public int QuantidadeDeItem { get; set; }
        public DateTime DataRegistro { get; set; }
        public bool EmUso { get; set; }
    }
}