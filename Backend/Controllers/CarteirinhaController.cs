

using Backend.Model.Request;
using Backend.Model.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCompression;

namespace Backend.Controllers
{
    [ApiController ]
    [Route("[controller]")]
    public class CarteirinhaController: ControllerBase
    {

        [HttpGet]
        [Route("obter/{nome}/{}")]
        public CarteirinhaResponse ObterCarteirinha([FromQuery] CarteirinhaRequest request)
        {
            var anoNascimento = request.Nascimento.Year;
            var anoAtual = DateTime.Now;
            var idade = anoAtual - anoNascimento;
            var response = new CarteirinhaResponse();
            response.Nome = request.Nome;
            response.Nascimento = request.Nascimento;   

            if(idade<=17)
            {
                response.CorDeFundo = request.CorDeFundo;
            }

            return response;
        }
    }
}
