using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemasDistribuidosPix.Model;
using System.Reflection;

namespace SistemasDistribuidosPix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebhookController : ControllerBase
    {

        [HttpPost]
        public string receberDadosWebhook(ReceberPix receberPix)
        {
            // Percorrendo cada objeto Pix na lista
            foreach (var pix in receberPix.pix)
            {
                Console.WriteLine($"EndToEndId: {pix.endToEndId}");
                Console.WriteLine($"Txid: {pix.txid}");
                Console.WriteLine($"Valor: {pix.valor}");
                Console.WriteLine($"ComponentesValor: {pix.componentesValor.original.valor}");
                Console.WriteLine($"Nome do pagador: {pix.pagador.nome}");
                Console.WriteLine($"Cpf do pagador: {pix.pagador.cpf}");
                Console.WriteLine($"Chave: {pix.chave}");
                Console.WriteLine($"Horário: {pix.horario}");
                Console.WriteLine($"InfoPagador: {pix.infoPagador}");
                Console.WriteLine();
            }
            return "a";
        }

    }
}
