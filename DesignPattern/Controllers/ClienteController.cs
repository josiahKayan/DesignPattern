using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPattern.DI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public string Get()
        {

            var cliente = new Cliente
            {
                Nome = "Josias"
            };

            _clienteService.Adicionar(cliente);

            return "Adicionado";
        }


    }
}