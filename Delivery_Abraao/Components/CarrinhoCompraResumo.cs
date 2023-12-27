using Delivery_Abraao.Models;
using Delivery_Abraao.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Delivery_Abraao.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {

            var itens = _carrinhoCompra.GetCarrinhoCompraItems();

            //var itens = new List<CarrinhoCompraItem>()
            //{
            //    new CarrinhoCompraItem(),
            //    new CarrinhoCompraItem()
            //};
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()

            };

            return View(carrinhoCompraVM);
        }
    }
}
