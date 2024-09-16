
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
    }
}
