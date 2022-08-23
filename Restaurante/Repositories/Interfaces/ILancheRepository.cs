using Restaurante.Models;

namespace Restaurante.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get;}
        Lanche GetLancheById(int lancheid);

    }
}
