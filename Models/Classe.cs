using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_classes_de_um_jogo.classe
{
    public class Classe 
    {
        private string nome { get; set; }
        private int idade { get; set; }
        private string tipo { get; set; }
        private string ataque { get; set; }
    
        public Classe ( string nome, int idade, string tipo, string ataque)
        {
            this.nome = nome;
            this.idade = idade;
            this.tipo = tipo;
            this.ataque = ataque;
        }

        public void apresentar()
        {
            Console.WriteLine($"Seu nome é: {nome}, tem {idade} anos e está usando a classe {tipo}" );
        }

        public void atacar()
        {
            Console.WriteLine($"o {tipo} atacou usando {ataque}");
        }

        public void escolherClasse()
        {
            Console.WriteLine("Escolha sua Classe: ");

            string opcao = string.Empty;
            bool exibirMenu = true;


            while (exibirMenu)
            {
                Console.WriteLine("Digite a sua classe:");
                Console.WriteLine("1 - Mago");
                Console.WriteLine("2 - Guerreiro");
                Console.WriteLine("3 - Monge");
                Console.WriteLine("4 - Ninja");

                switch (Console.ReadLine())
                {
                    case "1":
                    tipo = "mago";
                    ataque = "magia";
                    exibirMenu = false;
                    Console.Clear();
                    break;

                    case "2":
                    tipo = "guerreiro";
                    ataque = "espada";
                    exibirMenu = false;
                    Console.Clear();
                    break;

                    case "3":
                    tipo = "monge";
                    ataque = "artes marciais";
                    exibirMenu = false;
                    Console.Clear();
                    break;

                    case "4":
                    tipo = "ninja";
                    ataque = "shuriken";
                    exibirMenu = false;
                    Console.Clear();
                    break;

                    default:
                    Console.WriteLine("Opção inválida");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
                Console.Clear();
            }
        }
    }
}
    
