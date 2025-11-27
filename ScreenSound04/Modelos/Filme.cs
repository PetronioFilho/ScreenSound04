using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound04.Modelos
{
    internal class Filme
    {
        [JsonPropertyName("title")]
        public string Titulo { get; set; }

        [JsonPropertyName("fullTitle")]
        public string TituloCompleto { get; set; }

        [JsonPropertyName("year")]
        public string Ano { get; set; }

        [JsonPropertyName("crew")]
        public string Diretor { get; set; }

        public void ExibirDetalhesdoFilme()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Título Completo: {TituloCompleto}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Diretor: {Diretor}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
