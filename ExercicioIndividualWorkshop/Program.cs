using System;
using System.Threading.Channels;
using Models;

namespace ExercicioIndividualWorkshop
{
    public class Program
    {
        private static Zoologico zoo = new Zoologico();

        static void Main(string[] args)
        {
            zoo.Endereco = "Rua das Árvores, Reserva Florestal";
            zoo.RazaoSocial = "ZooGarden";
            zoo.CNPJ = "123456789/0001-00";
            zoo.Animais = new List<Animal>();
            zoo.Veterinarios = new List<Veterinario>();

            do
            {
                Menu();

            } while (true);

        }

        public static void Menu()
        {
            Console.WriteLine("Bem vindo ao zoológico " + zoo.RazaoSocial + "!\n");
            Console.WriteLine("1 - Cadastrar Veterinário");
            Console.WriteLine("2 - Cadastrar Animal");
            Console.WriteLine("3 - Examinar Animal");
            Console.WriteLine("4 - Examinar Todos os Animais");
            Console.WriteLine("5 - Informações Zoológico");
            Console.WriteLine("6 - Sair");
            Console.WriteLine();
            Console.WriteLine("Digite a opção desejada: ");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    var veterinario = Veterinario.CadastrarVeterinario();
                    zoo.Veterinarios.Add(veterinario);
                    break;
                case "2":
                    Console.Clear();
                    var animal = Animal.CadastrarAnimal();
                    if (animal != null)
                    {
                        zoo.Animais.Add(animal);
                    }
                    break;
                case "3":
                    Console.Clear();
                    Veterinario.ExaminarAnimalExistente(zoo);
                    break;
                case "4":
                    Console.Clear();
                    Veterinario.ExaminarTodosAnimais(zoo);
                    break;
                case "5":
                    Console.Clear();
                    Zoologico.InformacoesZoologico(zoo);
                    break;
                case "6":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine("\nAperte qualquer tecla para continuar: ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }  
    }
}
