using IndiceDesemprego.Dominio;
using System;
using System.Collections.Generic;

namespace IndiceDesemprego.Repositorio
{
    public class JovemRepositorio
    {
        public List<Jovem> Jovens { get; set; } = new List<Jovem>();

        internal void Adicionar(Jovem jovem) => Jovens.Add(jovem);

        internal List<Jovem> BuscarJovens()
        {
            return Jovens;
        }
    }
}
