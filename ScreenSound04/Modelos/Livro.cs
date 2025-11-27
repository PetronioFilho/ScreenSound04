using System.Text.Json.Serialization;

namespace ScreenSound04.Modelos
{
    internal class Livro
    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("autor")]
        public string Autor { get; set; }

        [JsonPropertyName("ano_publicacao")]
        public int AnoPublicacao { get; set; }

        [JsonPropertyName("genero")]
        public string Genero { get; set; }

        [JsonPropertyName("paginas")]
        public int Paginas { get; set; }

        [JsonPropertyName("editora")]
        public string Editora { get; set; }

        public void ExibirDetalhesDoLivro()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Ano de Publicação: {AnoPublicacao}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Número de Páginas: {Paginas}");
            Console.WriteLine($"Editora: {Editora}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
