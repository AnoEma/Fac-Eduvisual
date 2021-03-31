using System;

namespace Eduvisual.Domain
{
    public class CadastroClientes : Usuario
    {
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
        public bool Excluido { get; set; }
        public DateTime DataDeCadastro { get; set; }
    }
}