﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Restaurante.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [StringLength(100,ErrorMessage ="O tamanho maximo é 100 caracteres")]
        [Required(ErrorMessage ="informe o nome da categoria")]
        [Display(Name ="Nome")]
        public string CategoriaNome { get; set; }


        [StringLength(200, ErrorMessage = "O tamanho maximo é 200 caracteres")]
        [Required(ErrorMessage = "informe a descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; } = new List<Lanche>();


    }
}
