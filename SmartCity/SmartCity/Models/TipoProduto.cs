using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCity.Models
{
    public class TipoProduto
    {   
        public int Id { get; set; }
        [Required(ErrorMessage = "Descrição obrigatória!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "A descrição deve possuir no mínimo 3 e no máximo 50 caracteres")]
        [Display(Name ="Type the product description! ☻")]
        public string Description { get; set; }

        public bool Commercialization { get; set; }


    }
}
