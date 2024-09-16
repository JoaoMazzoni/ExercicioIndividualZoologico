using System;
using System.Collections.Generic;
using Models.Animal;

namespace Models.Zoologico
{
    public class Zoologico
	{
        public Zoologico()
		{
        }

        public string RazaoSocial { get; set; }

        public string CNPJ { get; set; }

        public List<Animal> Animais { get; set; }
    }
}
