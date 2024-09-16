
namespace Models
{
    public class Veterinario
    {
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
    }
}
