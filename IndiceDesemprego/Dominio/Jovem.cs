namespace IndiceDesemprego.Dominio
{
    public class Jovem
    {
        public Jovem()
        {
        }

        public Jovem(Genero genero, bool trabalha, string nome)
        {
            Genero = genero;
            Trabalha = trabalha;
            Nome = nome;
        }

        public Genero Genero { get; set; }

        public bool Trabalha { get; set; }

        public string Nome { get; set; }

    }
}
