
namespace Restaurante.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategosriaNome { get; set; }
        public string Descricao { get; set; }
        public List<Categoria> Categorias { get; set; }


    }
}
