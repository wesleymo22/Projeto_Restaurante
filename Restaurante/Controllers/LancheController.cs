using Microsoft.AspNetCore.Mvc;
using Restaurante.Migrations;
using Restaurante.Models;
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

        public IActionResult List(string categoria)
        {
           
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os Lanches";
            }
            else
            {
                if(string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
                        .OrderBy(l => l.Nome);
                    categoria = "Lanches tradicionais";
                }
                else if (string.Equals("Natural", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.CategoriaNome.Equals("Natural"))
                        .OrderBy(l => l.Nome);
                    categoria = "Lanches Naturais";
                }
                else
                {
                    lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                    categoria = "Todos os Lanches";
                    
                }
                categoriaAtual = categoria;
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);

        }
    }
}
