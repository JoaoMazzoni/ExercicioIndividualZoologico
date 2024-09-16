using System;
using Models.Animal;

namespace Models.Veterinario
{
    public class Veterinario
    {
        public Veterinario()
        {
        }

        public string Nome { get; set; }

        public string CRMV { get; set; }

        public string Telefone { get; set; }

        public void Examinar(Animal animal)
        {
            Console.WriteLine("Examinando o animal...");
            Console.WriteLine("Nome: " + animal.Nome);
            Console.WriteLine("Especie: " + animal.Especie);
            animal.EmitirSom();
            Console.WriteLine("Exame finalizado!");
        }
    }
}

