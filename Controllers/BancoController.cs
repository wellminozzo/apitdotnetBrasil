using System.ComponentModel.DataAnnotations;
using System.Net;
using brasilApi.Interfaces;
using brasilApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace brasilApi.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]


    public class BancoController: ControllerBase
    {
        public readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("busca/todos")]

        public async Task<IActionResult> BuscarTodosBancos()
        {

            var response = await _bancoService.BuscarTodosBancos();

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            
            }
            else 
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }

        }


        [HttpGet("busca/{codigoBanco}")]

        public async Task<IActionResult> Buscar([RegularExpression("^[0-9]*$")]string codigoBanco)
        {

            var response = await _bancoService.BuscarBanco(codigoBanco);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            
            }
            else 
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }

        }

    }



}



