using System;
using Aula34MVC.Controllers;

namespace Aula34MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoControler prod = new ProdutoControler();
            prod.Buscar("4,2");
            
        }
    }
}
