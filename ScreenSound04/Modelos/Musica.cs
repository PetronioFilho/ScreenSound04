using System.Text.Json.Serialization;

namespace ScreenSound04.Modelos
{
    internal class Musica
    {
        [JsonPropertyName("artist")]
        public string?  Artista { get; set; }

        [JsonPropertyName("song")]
        public string? Nome { get; set; }

        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }

        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Nome da Música: {Nome}");
            Console.WriteLine($"Duração (ms): {Duracao /1000}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
