namespace IndiceDesemprego.Dominio
{
    public class Resultado
    {
        public Resultado(ResultadoPorGenero homens, ResultadoPorGenero mulheres)
        {
            Homens = homens;
            Mulheres = mulheres;
        }

        public ResultadoPorGenero Homens { get; set; }

        public ResultadoPorGenero Mulheres { get; set; }
    }

    public class ResultadoPorGenero
    {
        public ResultadoPorGenero(decimal trabalham, decimal naoTrabalham)
        {
            Trabalham = trabalham;
            NaoTrabalham = naoTrabalham;
        }

        public decimal Trabalham { get; set; }

        public decimal NaoTrabalham { get; set; }
    }
}
