using System;

namespace Eduvisual.Application.ViewModels
{
    public class CadastroClientesViewModel : UsuarioModel
    {
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Cargo { get; set; }
    }
}