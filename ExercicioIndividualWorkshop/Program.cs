using System;
using System.Threading.Channels;
using Models;

namespace ExercicioIndividualWorkshop
{
    public class Program
    {
        private static Zoologico zoo = new Zoologico();
        private static Random random = new Random();

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
                    var veterinario = CadastrarVeterinario();
                    zoo.Veterinarios.Add(veterinario);
                    break;
                case "2":
                    Console.Clear();
                    var animal = CadastrarAnimal();
                    if (animal != null)
                    {
                        zoo.Animais.Add(animal);
                    }
                    break;
                case "3":
                    Console.Clear();
                    ExaminarAnimalExistente();
                    break;
                case "4":
                    Console.Clear();
                    ExaminarAnimais();
                    break;
                case "5":
                    Console.Clear();
                    InformacoesZoologico();
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
        public static Veterinario CadastrarVeterinario()
        {
            Console.WriteLine("Digite o nome do veterinário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o CRMV do veterinário: ");
            string crmv = Console.ReadLine();
            Console.WriteLine("Digite o telefone do veterinário: ");
            string telefone = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nVeterinário cadastrado com sucesso!");

            Veterinario veterinario = new Veterinario(nome, crmv, telefone);

            Console.WriteLine("Nome: " + veterinario.Nome);
            Console.WriteLine("CRMV: " + veterinario.CRMV);
            Console.WriteLine("Telefone: " + veterinario.Telefone);
            Console.WriteLine("\n");
            Console.WriteLine("Aperte qualquer tecla para continuar: ");
            Console.ReadKey();
            Console.Clear();

            return veterinario;
        }

        public static Animal CadastrarAnimal()
        {
            Console.WriteLine("Digite a espécie do animal: ");
            string especie = Console.ReadLine();

            if (especie == "Elefante")
            {
                Console.WriteLine("\nDigite o nome do elefante: ");
                string nomeElefante = Console.ReadLine();
                Elefante elefante = new Elefante();
                elefante.Nome = nomeElefante;
                Console.WriteLine("\nElefante cadastrado com sucesso!");
                Console.WriteLine("\nAperte qualquer tecla para continuar: ");
                Console.ReadKey();
                Console.Clear();

                return elefante;
            }
            else if (especie == "Preguiça")
            {
                Console.WriteLine("\nDigite o nome da preguiça: ");
                string nomePreguica = Console.ReadLine();
                Preguica preguica = new Preguica();
                preguica.Nome = nomePreguica;
                Console.WriteLine("\nPreguiça cadastrada com sucesso!");
                Console.WriteLine("\nAperte qualquer tecla para continuar: ");
                Console.ReadKey();
                Console.Clear();

                return preguica;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nEspécie não permitida para este zoológico!\n");
                Console.WriteLine("\nAperte qualquer tecla para continuar: ");
                Console.ReadKey();
                Console.Clear();
                return null;
            }
        }

        public static void ExaminarAnimalExistente()
        {
            if (zoo.Veterinarios.Count == 0)
            {
                Console.WriteLine("\nNenhum veterinário disponível para exame.");
                Console.WriteLine("\nPressione qualquer tecla para continuar: ");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            int indiceAleatorio = random.Next(zoo.Veterinarios.Count);
            Veterinario veterinario = zoo.Veterinarios[indiceAleatorio];

            Console.WriteLine("\nVeterinário do Turno\n");
            Console.WriteLine("Nome: " + veterinario.Nome);
            Console.WriteLine("CRMV: " + veterinario.CRMV);
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para iniciar os exames: ");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\nDigite o nome do animal que deseja examinar: ");
            string nomeAnimal = Console.ReadLine();

            foreach (Animal animal in zoo.Animais)
            {
                if (animal.Nome == nomeAnimal)
                {

                    veterinario.Examinar(animal);

                    Console.WriteLine("Aperte qualquer tecla para finalizar: ");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }

            Console.WriteLine("\nAnimal não encontrado!");
            Console.WriteLine("Pressione qualquer tecla para continuar: ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ExaminarAnimais()
        {
            Console.WriteLine("Examinando todos os animais...");

            if (zoo.Veterinarios.Count == 0)
            {
                Console.WriteLine("\nNenhum veterinário disponível para exame.");
                Console.WriteLine("\nPressione qualquer tecla para continuar: ");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            if(zoo.Animais.Count == 0)
            {
                Console.WriteLine("\nNão há animais cadastrados no Zoológico.");
                Console.WriteLine("\nPressione qualquer tecla para continuar: ");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            int indiceAleatorio = random.Next(zoo.Veterinarios.Count);
            Veterinario veterinario = zoo.Veterinarios[indiceAleatorio];

            Console.WriteLine("\nVeterinário do Turno\n");
            Console.WriteLine("Nome: " + veterinario.Nome);
            Console.WriteLine("CRMV: " + veterinario.CRMV);
            Console.WriteLine();

            veterinario.ExaminarAnimais(zoo.Animais);

            Console.WriteLine("Exame concluído para todos os animais.\n");
            Console.WriteLine("Pressione uma tecla para continuar: ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void InformacoesZoologico()
        {
            Console.WriteLine("\nInformações do Zoológico");
            Console.WriteLine("Razão Social: " + zoo.RazaoSocial);
            Console.WriteLine("CNPJ: " + zoo.CNPJ);
            Console.WriteLine("Endereço: " + zoo.Endereco);
            Console.WriteLine("Número de Veterinários: " + zoo.Veterinarios.Count);
            Console.WriteLine("\nVeterinários do Zoológico\n");

            if (zoo.Veterinarios.Count == 0)
            {
                Console.WriteLine("\nNão há veterinários cadastrados no zoológico.\n");
            }

            foreach (Veterinario veterinario in zoo.Veterinarios)
            {
                Console.WriteLine("Nome: " + veterinario.Nome);
                Console.WriteLine("CRMV: " + veterinario.CRMV);
                Console.WriteLine("Telefone: " + veterinario.Telefone);
                Console.WriteLine();
            }
            Console.WriteLine("\n\nNúmero de Animais: " + zoo.Animais.Count);
            Console.WriteLine("\nAnimais do Zoológico\n");
            if (zoo.Animais.Count == 0)
            {
                Console.WriteLine("\nNão há animais no Zoológico.\n");
            }
            foreach (Animal animal in zoo.Animais)
            {
                Console.WriteLine("Nome: " + animal.Nome);
                var tipo = animal.GetType();
                if (tipo == typeof(Elefante))
                {
                    Console.WriteLine("Espécie: Elefante\n");
                }
                else if (tipo == typeof(Preguica))
                {
                    Console.WriteLine("Espécie: Preguiça\n");
                }
             
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar: ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
