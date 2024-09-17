
using System;

namespace Models
{
    public class Veterinario
    {
        private readonly static Random random = new Random();
        public Veterinario()
        {
        }

        public Veterinario(string nome, string cRMV, string telefone)
        {
            Nome = nome;
            CRMV = cRMV;
            Telefone = telefone;
        }

        public string Nome { get; set; }

        public string CRMV { get; set; }

        public string Telefone { get; set; }

        public void Examinar(Animal animal)
        {
            Console.WriteLine("\nExaminando o animal...\n");
            Console.WriteLine("Dados do Animal Examinado\n");
            Console.WriteLine("Nome: " + animal.Nome);
            if(animal.GetType() == typeof(Preguica)) 
            {
                Console.WriteLine("Espécie: Preguiça");
            }
            else if(animal.GetType() == typeof(Elefante))
            {
                Console.WriteLine("Espécie: Elefante");
            }

            animal.EmitirSom();
            Console.WriteLine("\nExame finalizado!\n");
        }

        public void ExaminarAnimais(List<Animal> animais)
        {
            foreach (Animal animal in animais)
            {
                Examinar(animal);
                Console.WriteLine("Pressione qualquer tecla para examinar o próximo animal: ");
                Console.ReadKey();
                Console.Clear();    
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

        public static void ExaminarAnimalExistente(Zoologico zoo)
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


        public static void ExaminarTodosAnimais(Zoologico zoo)
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

            if (zoo.Animais.Count == 0)
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
            Console.WriteLine("CRMV: " + veterinario.CRMV); ;
            Console.WriteLine("\nPressione qualquer tecla para iniciar os exames: ");
            Console.ReadKey();
            Console.Clear();

            veterinario.ExaminarAnimais(zoo.Animais);

            Console.WriteLine("Exame concluído para todos os animais.\n");
            Console.WriteLine("Pressione uma tecla para continuar: ");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
