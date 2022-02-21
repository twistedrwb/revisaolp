using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadedeLP
{
    class Guerreiro
    {
        public string nome;
        public int forca;
        public int defesa;

        public void ExibirNome()
        {
            Console.WriteLine("Nome: " + this.nome);
        }
        public void ExibirDefesa() 
        {
            Console.WriteLine("Defesa: " + this.defesa);
        }
        public void ExibirForca()
        {
            Console.WriteLine("Força: " + this.forca);
        }
        public bool Atacar(int DefesaInimigo)
        {
            if (this.forca > DefesaInimigo)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
