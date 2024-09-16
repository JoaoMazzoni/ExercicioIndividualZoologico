namespace Models
{
    public abstract class Animal
    {
        public Animal()
        {
        }

        public string Nome { get; set; }

        public abstract void EmitirSom();

    }
}
