using Delivery_Abraao.Models;

namespace Delivery_Abraao.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
