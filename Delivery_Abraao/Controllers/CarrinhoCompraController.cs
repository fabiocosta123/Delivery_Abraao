using Delivery_Abraao.Models;
using Delivery_Abraao.Repositories.Interfaces;
using Delivery_Abraao.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Delivery_Abraao.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository,
            CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
                
            };

            return View(carrinhoCompraVM);
        }

        public RedirectToActionResult AdicionarItemCarrinhoCompra (int lancheId)
        {
           var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);
            if(lancheSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado);
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinho (int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);
            if(lancheSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);

            }
            return RedirectToAction("Index");
        }
    }
}
