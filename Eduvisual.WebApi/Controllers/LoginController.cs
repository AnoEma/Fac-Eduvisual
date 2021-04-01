using Eduvisual.Application.InterfacesServices;
using Eduvisual.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

namespace Eduvisual.WebApi.Controllers
{
    [ApiController]
    [Route("login")]
    [Produces("application/json")]
    public class LoginController : Controller
    {
        private readonly ILoginService _service;

        public LoginController(ILoginService service)
        {
            _service = service;
        }

        [HttpPost]
        [Route("form")]
        public IActionResult Logon(UsuarioModel model)
        {
            try
            {
                _service.InsertLogin(model);
                return StatusCode((int)HttpStatusCode.OK);
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