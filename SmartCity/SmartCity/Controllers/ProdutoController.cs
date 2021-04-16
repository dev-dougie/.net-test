using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCity.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            IList<Models.Produto> produtoList = new List<Models.Produto>();
            produtoList.Add(new Models.Produto
            {
                Id = 1,
                ProductName = "Geladeira",
                Price = 2600,
                Features = "Modelo 2021",
                IsActive = true,
                Logo = "Electrolux"
            });
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar() {
            return View(new Models.TipoProduto());
        }

    }
}
