using System.Collections.Generic;
using Aula34MVC.Models;
using Aula34MVC.Views;

namespace Aula34MVC.Controllers
{
    public class ProdutoControler
    {
        Produto produtoModel = new Produto();
        ProdutoViews produtoView = new ProdutoViews();

        public void Listar(){
            List<Produto> lista = produtoModel.Ler();
            produtoView.MostrarNoConsole(lista);
            
        }
        public void Buscar(string termo){
           List<Produto> lista = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(termo));
           produtoView.MostrarNoConsole(lista);
        }
    }
}