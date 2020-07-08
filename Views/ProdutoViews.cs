using System.Collections.Generic;
using Aula34MVC.Models;
using System;

namespace Aula34MVC.Views
{
    public class ProdutoViews
    {
        public void MostrarNoConsole(List<Produto> lista){
            foreach(Produto item in lista){
                System.Console.WriteLine($"{item.Preco} - {item.Nome}");
            }
        }
    }
}