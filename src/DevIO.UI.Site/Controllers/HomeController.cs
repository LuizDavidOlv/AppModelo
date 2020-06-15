using Microsoft.AspNetCore.Mvc;
using static DevIO.UI.Site.Data.PedidoRepository;

namespace DevIO.UI.Site.Controllers
{
    public class HomeController : Controller
    {
        private IPedidoRepository _pedidoRepository;


        public HomeController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }


        public IActionResult Index()
        {
            var pedido = _pedidoRepository.ObterPedido();
            return View();
        }
    }
}
