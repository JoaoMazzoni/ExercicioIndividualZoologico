namespace Models
{
    public abstract class Animal
    {
        public Animal()
        {
        }

        public string Nome { get; set; }

        public abstract void EmitirSom();

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

    }
}
