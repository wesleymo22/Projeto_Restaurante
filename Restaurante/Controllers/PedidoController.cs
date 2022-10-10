using Microsoft.AspNetCore.Mvc;
using Restaurante.Models;
using Restaurante.Repositories.Interfaces;

namespace Restaurante.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Chechout(Pedido pedido)
        {
            return View();
        }
    }
}
