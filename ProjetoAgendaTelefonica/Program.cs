using System.Net.NetworkInformation;
string[] nomes = new string[5];
string[] telefones = new string[5];
int quantidade = 0;

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n --- Agenda telefonica ------");
    Console.WriteLine("1 - cadastrar contatos ");
    Console.WriteLine("2 - listar contatos ");
    Console.WriteLine("3 - sair ");
    Console.WriteLine("Escolha a opção: ");
    string opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            
            íf(quantidade < 5)
            {
                Console.Write("Digite o nome do contato: ");
                nomes[quantidade] = Console.ReadLine();
                Console.Write("Digite o telefone do contato: ");
                telefones[quantidade] = Console.ReadLine();

                Console.WriteLine("Contato cadastrado com sucesso!");
                
                quantidade++;
            }
            else
            {
                Console.WriteLine("Agenda cheia! Só é possivel cadastrar 5 contatos.");
            }
            break;
        case "2":
            Console.WriteLine("\n --- Lista de Contatos ---");
            if(quantidade == 0)
            {
                Console.WriteLine("Nenhum contato cadastrado.");
            }
            else
            {
                for(int i = 0; i < quantidade; i++)
                {
                    Console.WriteLine($" {i + 1} - Nome: {nomes[i]}, Telefone: {telefones[i]}");
                }
            }
            break;
        case "3":
            continuar = false;
            Console.WriteLine("Encerrando o progranma");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}