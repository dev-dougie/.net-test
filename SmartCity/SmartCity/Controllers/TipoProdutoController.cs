using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCity.Controllers
{
    public class TipoProdutoController : Controller
    {
        public IActionResult Index()
        {
            IList<Models.TipoProduto> productList = new List<Models.TipoProduto>();

            productList.Add(new Models.TipoProduto()
            {
                Id = 1,
                Description = "Tinta",
                Commercialization = true
            });
            productList.Add(new Models.TipoProduto() 
            { 
                Id = 2,
                Description = "Filtro de água",
                Commercialization = true
            });
            productList.Add(new Models.TipoProduto()
            {
                Id = 3,
                Description = "Captador de energia",
                Commercialization = false
            });


            return View(productList);
        }

        [HttpGet]
        public IActionResult Cadastrar() {

            System.Diagnostics.Debug.Print("Executou a action cadastrar!");

            return View(new Models.TipoProduto());
        }

        [HttpPost]
        public IActionResult Cadastrar(Models.TipoProduto tipoProduto) {

            if (ModelState.IsValid) {
                System.Diagnostics.Debug.Print("Descrição: " + tipoProduto.Description);

                System.Diagnostics.Debug.Print("Comercializado: " + tipoProduto.Commercialization);

                System.Diagnostics.Debug.Print("Gravando o Tipo de produto");
            }
            else {
                return View(tipoProduto);
            }

            @TempData["sucesso"] = "Tipo de produto cadastrado com sucesso!";
            return RedirectToAction("Index", "TipoProduto");

        }


        [HttpGet]
        public IActionResult Editar(int Id)
        {
            // Imprime a mensagem de execução
            System.Diagnostics.Debug.Print("Consultando o Tipo com Id = " + Id);
            // Cria o modelo que SIMULA a consulta no  banco de dados
            Models.TipoProduto tipoProduto = new Models.TipoProduto()
            {
                Id = Id,
                Description = "Tinta",
                Commercialization = true
            };
            // Retorna para a View o objeto modelo 
            // com as propriedades preenchidas com dados do banco de dados 
            return View(tipoProduto);
        }
        [HttpPost]
        public IActionResult Editar(Models.TipoProduto tipoProduto)
        {
            // Imprime os valores do modelo
            System.Diagnostics.Debug.Print("Descrição: " + tipoProduto.Description);
            System.Diagnostics.Debug.Print("Comercializado: " + tipoProduto.Commercialization);
            // Simila que os dados foram gravados.
            System.Diagnostics.Debug.Print("Gravando o Tipo Editado");
            // Substituímos o return View()
            // pelo método de redirecionamento
            return RedirectToAction("Index", "TipoProduto");
        }

        [HttpGet]
        public IActionResult Consultar(int Id)
        {
            // Imprime a mensagem de execução
            System.Diagnostics.Debug.Print("Consultando o Tipo com Id = " + Id);
            // Cria o modelo que SIMULA a consulta no  banco de dados
            Models.TipoProduto tipoProduto = new Models.TipoProduto()
            {
                Id = Id,
                Description = "Tinta",
                Commercialization = true
            };
            // Retorna para a View o objeto modelo 
            // com as propriedades preenchidas com dados do banco de dados 
            return View(tipoProduto);
        }

        public IActionResult Excluir(int Id) {
            System.Diagnostics.Debug.Print("Item com o id " + Id + " excluído!");

            return RedirectToAction("Index", "TipoProduto");
        }

    }
}
