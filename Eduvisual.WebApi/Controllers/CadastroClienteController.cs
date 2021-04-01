using Eduvisual.Application.InterfacesServices;
using Eduvisual.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Eduvisual.WebApi.Controllers
{
    [ApiController]
    [Route("cadastro-cliente")]
    [Produces("application/json")]
    public class CadastroClienteController : Controller
    {
        private readonly ICadastraClientesServices _services;

        public CadastroClienteController(ICadastraClientesServices services)
        {
            _services = services;
        }

        [HttpGet]
        [Route("clientes")]
        public IActionResult Index()
        {
            var clientes = _services.GetAllClientes();
            return Ok(clientes);
        }

        [HttpPost]
        [Route("adicionar")]
        public IActionResult AddClientes(CadastroClientesViewModel model)
        {
            try
            {
                _services.InsertCliente(model);
                return StatusCode((int)HttpStatusCode.Created);
            }
            catch (ApplicationException ex)
            {
                return StatusCode((int)HttpStatusCode.BadRequest, ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}