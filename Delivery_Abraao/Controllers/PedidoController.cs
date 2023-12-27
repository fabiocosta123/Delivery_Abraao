using Delivery_Abraao.Models;
using Delivery_Abraao.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Delivery_Abraao.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            this.pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Pedido pedido)
        {
            int totalItensPedido = 0;
            decimal precoTotalPedido = 0.0m;

            // obtem os itens do carrinho de compra do cliente
            List<CarrinhoCompraItem> items = _carrinhoCompra.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = items;

            // verifica se existe itens de pedido
            if(_carrinhoCompra.CarrinhoCompraItems.Count == 0)
            {
                ModelState.AddModelError("", "Seu carrinho está vazio, inclua pelo menos um item");


            }

            // calcular o total de itens e total de pedidos
            foreach(var item in items)
            {
                totalItensPedido += item.Quantidade;
                precoTotalPedido += (item.Lanche.Preco * item.Quantidade);
            }

            // atribuir os valores obtido aos pedidos
            pedido.TotalItensPedido = totalItensPedido;
            pedido.PeditoTotal = precoTotalPedido;

            // validar dados do pedido
            if (ModelState.IsValid)
            {
                // criar o pedido e os detalhes do pedido
                pedidoRepository.CriarPedido(pedido);

                //define mensagens ao cliente
                ViewBag.CheckoutCompletoMensagem = "Obrigado pelo seu pedido :)";
                ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoCompraTotal();

                //limpa o carrinho do cliente
                _carrinhoCompra.LimparCarrinho();

                //exibir a view com dados do cliente e do pedido
                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
            }
            return View(pedido);
        }
    }
}
