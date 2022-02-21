using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadedeLP
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro p1 = new Guerreiro();
            p1.nome = "Guerreiro Toppers";
            p1.forca = 100;
            p1.defesa = 200;

            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Força: " + p1.forca);
            Console.WriteLine("Defesa: " + p1.defesa);

            if (p1.Atacar(500))
            {
                Console.WriteLine("Resultado da luta: Vitória!");
            }
            else
            {
                Console.WriteLine("Resultado da luta: Perdeu!");
            }

            Console.ReadKey();
        }
    }
}
