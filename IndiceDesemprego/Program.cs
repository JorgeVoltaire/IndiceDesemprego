using IndiceDesemprego.Dominio;
using IndiceDesemprego.Repositorio;
using System;

namespace IndiceDesemprego
{
    class Program
    {
        static void Main(string[] args)
        {
            var repositorio = new JovemRepositorio();

            var calculadora = new Calculadora();

            //Considerando o cenário apresentado, crie um programa que permita o cálculo dos percentuais apresentados no gráfico,
            //    mediante à leitura de dados de diversos jovens. O programa deve ter uma classe(denominada Jovem), 
            //    que irá conter diversos atributos, dentre eles, obrigatoriamente: o gênero do jovem e se ele trabalha ou não.
            //    O programa deve ler os atributos, armazenando 50 objetos(referentes aos 50 jovens entrevistados) em uma lista.
            //    Depois de populada, a lista deverá ser percorrida para que os percentuais sejam calculados
            //    e mostrados em quatro categorias, conforme o gráfico apresentado: percentual de homens que não trabalham,
            //    percentual de homens que trabalham, percentual de mulheres que não trabalham,
            //    percentual de mulheres que trabalham.

            //Criar 50 objetos de jovem
            //Armazenar os objetos
            CadastrarJovens(repositorio);


            //Calcular percentuais
            var jovens = repositorio.BuscarJovens();

            var resultado = calculadora.Calcular(jovens);

            //Mostrar em categorias
            Console.WriteLine($"Percentual de homens que trabalham: {resultado.Homens.Trabalham}%");
            Console.WriteLine($"Percentual de homens que não trabalham: {resultado.Homens.NaoTrabalham}%");
            Console.WriteLine($"Percentual de mulheres que trabalham: {resultado.Mulheres.Trabalham}%");
            Console.WriteLine($"Percentual de mulheres que não trabalham: {resultado.Mulheres.NaoTrabalham}%");
        }

        private static void CadastrarJovens(JovemRepositorio repositorio)
        {
            for (int i = 0; i < 50; i++)
            {
                Genero genero = i % 2 == 0 ? Genero.Masculino : Genero.Feminino;

                repositorio.Adicionar(new Jovem(genero, i % 2 != 0, $"Fulano 0{i+1}"));
            }
        }
    }
}
