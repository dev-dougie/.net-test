using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCity.Models
{
    public class Produto
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Nome do produto obrigaório!")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Recursos obrigatórios")]
        public string Features { get; set; }
        [Required(ErrorMessage = "Preço obrigatório!")]
        public double Price { get; set; }
        public string Logo { get; set; }
        public bool IsActive { get; set; }
        public TipoProduto ProductType { get; set; }
    }
}
