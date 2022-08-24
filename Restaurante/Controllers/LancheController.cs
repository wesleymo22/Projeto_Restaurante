using Microsoft.AspNetCore.Mvc;
using Restaurante.Repositories.Interfaces;
using Restaurante.ViewModels;

namespace Restaurante.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            /*
            var lanches = _lancheRepository.Lanches;
            return View(lanches);
            */
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lanchesListViewModel);

        }
    }
}
