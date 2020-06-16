using DevIO.UI.Site.Data;
using Microsoft.AspNetCore.Mvc;
using static DevIO.UI.Site.Data.PedidoRepository;

namespace DevIO.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;


        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }


        public IActionResult Index() //[FromServices] IPedidoRepository _pedidoRepository  ----Só usar quando não puder de jeito algum mexer no construtor !!!
        {
            var pedido = _pedidoRepository.ObterPedido();
            return View();
        }
    }
}
