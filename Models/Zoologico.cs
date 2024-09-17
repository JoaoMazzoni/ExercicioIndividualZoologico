
namespace Models
{
    public class Zoologico
    {
        public Zoologico()
        {
        }

        public Zoologico(string razaoSocial, string cnpj, string endereco, List<Animal> animais, List<Veterinario> veterinarios)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            Endereco = endereco;
            Animais = animais;
            Veterinarios = veterinarios;
        }

        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }

        public string Endereco { get; set; }

        public List<Animal> Animais { get; set; }

        public List<Veterinario> Veterinarios { get; set; }

        public static void InformacoesZoologico(Zoologico zoo)
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
