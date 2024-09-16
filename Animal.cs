using System;

namespace Models.Animal
{

	public class Animal
	{
		public Animal()
		{
		}

		public string Nome { get; set; }

		public string Especie { get; set; }

		public override void EmitirSom();

	}
}
