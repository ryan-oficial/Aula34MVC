using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula34MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        private const string PATH = "Database/produto.csv";

        public Produto()
        {   

            
            string pasta = PATH.Split('/')[0];
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public List<Produto> Ler(){
            // Lista de produto
            List<Produto> prod = new List<Produto>();

            // Linhas tranformadas em array de strings
            string[] linhas = File.ReadAllLines(PATH);

            // Varremos esse array de strings
            foreach (var linha in linhas){ 

                // Quebra de linha em partes
                string[] dados = linha.Split(";");

                // Tratamos e adicionamos dados em um novo produto
                Produto p = new Produto();
                p.Codigo = Int32.Parse( SepararDado(dados[0]));
                p.Nome = SepararDado(dados[1]);
                p.Preco = float.Parse(SepararDado(dados[2]));

                // Adicionado o produto antes de retorna-lo
                prod.Add(p);
            }
            prod = prod.OrderBy(z => z.Nome).ToList();

            return prod;
        }

        public string SepararDado(string dados){
            return dados.Split("=")[1];
        }
    }
}