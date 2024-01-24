using Desafio_classes_de_um_jogo.classe;

Console.Clear();

Console.OutputEncoding = System.Text.Encoding.UTF8;

string nome = "";
int idade = 0;
string tipo = "";
string ataque = "";


Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

Console.Clear();

Console.WriteLine("Digite dua Idade: ");
idade = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Classe conta = new Classe(nome, idade, tipo, ataque);

conta.escolherClasse();

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer:");
    Console.WriteLine("1 - Atacar");
    Console.WriteLine("2 - Trocar de classe");
    Console.WriteLine("3 - Sua conta");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            conta.atacar();
            break;

        case "2":
            conta.escolherClasse();
            break;

        case "3":
            conta.apresentar();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");









