using Delivery_Abraao.Models;

namespace Delivery_Abraao.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual {  get; set; }
    }
}
