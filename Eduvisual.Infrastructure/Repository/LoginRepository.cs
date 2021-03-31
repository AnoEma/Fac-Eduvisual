using Eduvisual.Domain;
using Eduvisual.Domain.Interfaces;
using Eduvisual.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eduvisual.Infrastructure.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly EduvisualContext _context;

        public LoginRepository(EduvisualContext context)
        {
            _context = context;
        }
        public void InsertLogin(Usuario login)
        {
            var usuario = _context.CadastroClientes.Where(x => x.UserName == login.UserName && x.Password == login.Password).FirstOrDefault();

            if (usuario == null)
            {
                throw new ArgumentException("Erro");
            }

            if(usuario.Excluido != false)
            {
                throw new ArgumentException("Usuario inativado, Entra em contato com seu superior");
            }
        }
    }
}