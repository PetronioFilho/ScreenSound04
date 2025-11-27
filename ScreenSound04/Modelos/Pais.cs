using System.Text.Json.Serialization;

namespace ScreenSound04.Modelos
{
    internal class Pais
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("capital")]
        public string Capital { get; set; }

        [JsonPropertyName("populacao")]
        public long Populacao { get; set; }

        [JsonPropertyName("continente")]
        public string Continente { get; set; }

        [JsonPropertyName("idioma")]
        public string Idioma { get; set; }

        public void ExibirDetalhesDoPais()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Capital: {Capital}");
            Console.WriteLine($"População: {Populacao}");
            Console.WriteLine($"Continente: {Continente}");
            Console.WriteLine($"Idioma: {Idioma}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
