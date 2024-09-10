using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projCoisaMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coisas minhasCoisas = new Coisas(10);
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(1, "Bala de banana")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(2, "Prensadão")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(3, "Café")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(4, "Frango")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(5, "Agua sem gás")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(6, "Kitkat")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(7, "Suco de laranja")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(8, "Chiclete de hortelã")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(9, "Coxinha de frango")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(10, "Bolinho de queijo")) ? "Adicionou" : "Não adicionou");
            Console.WriteLine(minhasCoisas.adicionar(new Coisa(11, "Refrigerante de guaraná")) ? "Adicionou" : "Não adicionou");

            Console.WriteLine("---------------------");

            Console.WriteLine(minhasCoisas.mostrar());
            Console.WriteLine("---------------------");

            Coisa coisaPesquisada = new Coisa(2);
            Coisa coisaAchada = minhasCoisas.pesquisar(coisaPesquisada);
            if (coisaAchada.Id == -1)
            {
                Console.WriteLine("Coisa não encontrada");
            }
            else
            {
                Console.WriteLine(coisaAchada.ToString());
            }

            minhasCoisas.remover(new Coisa(1));
            minhasCoisas.remover(new Coisa(10));
            minhasCoisas.remover(new Coisa(11));
            minhasCoisas.remover(new Coisa(6));
            minhasCoisas.remover(new Coisa(2));

            Console.WriteLine("---------------------");


            Console.WriteLine("Fim");

            Console.ReadKey();

        }
    }
}
