using System;
using System.Collections.Generic;
using System.Linq;

namespace IndiceDesemprego.Dominio
{
    public class Calculadora
    {
        internal Resultado Calcular(List<Jovem> jovens)
        {
            var homens = CalcularResultado(jovens.Where(x => x.Genero == Genero.Masculino), jovens);

            var mulheres = CalcularResultado(jovens.Where(x => x.Genero == Genero.Feminino), jovens);

            return new Resultado(homens, mulheres);
        }

        private ResultadoPorGenero CalcularResultado(IEnumerable<Jovem> grupo, IEnumerable<Jovem> total)
        {
            decimal trabalham = (Convert.ToDecimal(grupo.Where(x => x.Trabalha).Count()) / total.Count()) * 100;

            decimal naoTrabalham = (Convert.ToDecimal(grupo.Where(x => !x.Trabalha).Count()) / total.Count()) * 100;

            return new ResultadoPorGenero(trabalham, naoTrabalham);
        }
    }
}
