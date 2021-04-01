using Eduvisual.Application.InterfacesServices;
using Eduvisual.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Eduvisual.WebApi.Controllers
{
    [ApiController]
    [Route("equipamento")]
    [Produces("application/json")]
    public class EquipamentoController : Controller
    {
        private readonly IEquipamentoInfoServices _services;

        public EquipamentoController(IEquipamentoInfoServices services)
        {
            _services = services;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetEquipamentos()
        {
            var equipamento = _services.Equipamento();
            return Ok(equipamento);
        }

        [HttpGet]
        [Route("em-uso")]
        public IActionResult GetEquipamentoEmUso()
        {
            var equipamento = _services.EquipamentoEmUso();
            return Ok(equipamento);
        }

        [HttpGet]
        [Route("sem-uso")]
        public IActionResult GetEquipamentoSemUso()
        {
            var equipamento = _services.EquipamentoSemUso();
            return Ok(equipamento);
        }

        [HttpPost]
        [Route("adicionar-equipamento")]
        public IActionResult AddEquipamento(EquipamentoDeInformaticaModel equipamento)
        {
            try
            {
                _services.InsertEquipamentoInfo(equipamento);
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