using Delivery_Abraao.Models;

namespace Delivery_Abraao.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int LancheId);
    }
}
