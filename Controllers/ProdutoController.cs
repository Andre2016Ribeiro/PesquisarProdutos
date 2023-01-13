using Microsoft.AspNetCore.Mvc;
using PesquisarProdutos.Models;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PesquisarProdutos.Controllers
{  
    public class ProdutoController : Controller
    { public static List<Produto> Produtos = new List<Produto>()
        {
            new Produto(){ id = 1, nome = "DDD"},
            new Produto(){ id = 2, nome = "BBB"},
            new Produto(){ id = 3, nome = "AAA"},
            new Produto(){ id = 4, nome = "CCC"}
        };
        public IActionResult Index()
        {
            ViewBag.Produtos = Produtos;    
            return View();
        }
        public ViewResult Edit(int id)
        {
            

            ViewBag.a = id-1;
            ViewBag.b = Produtos[id-1].nome;
          

            




            return View();
        }
        [HttpPost]
        public ViewResult Edit(Produto novo)
        {
            int ind = novo.id-1;


            Produtos[ind].nome = novo.nome;
               
            
         



            
            return (ViewResult)Index();
        }
        
        public ViewResult Delete(int id)
        {


            ViewBag.a = id - 1;
            ViewBag.b = Produtos[id - 1].nome;







            return View();
        }
        [HttpPost]
        public ViewResult Delete(int id, string nome)
        {



            Produtos.RemoveRange(id-1,1);








            

            return View();
        }
        public ViewResult Create()
        {

            
            ViewBag.a = Produtos.Last().id;
            







            return View();
        }
        [HttpPost]
        public ViewResult Create(Produto novo)
        {



            Produtos.Add(novo);










            return View();
        }

    }
}
