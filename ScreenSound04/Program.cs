


using ScreenSound04;
using ScreenSound04.Modelos;
using System.Text.Json;

//O Http Client é usado para fazer requisições HTTP em C# e permite enviar e receber dados de servidores web.
//using (HttpClient client = new HttpClient())
//{
//	try
//	{
//        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

//		var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
//		if (musicas != null)
//		{
//			foreach (var musica in musicas)
//			{
//				musica.ExibirDetalhesDaMusica();
//			}
//        }
//    }
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);
//	}
//}


internal class Program
{
    private static async Task Main(string[] args)
    {
        var musicas = ClientApi<Musica>.Listar(new Musica(), "https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        foreach (var musica in await musicas)
        {
            musica.ExibirDetalhesDaMusica();
        }

        var filmes = ClientApi<Filme>.Listar(new Filme(), "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        foreach (var filme in await filmes)
        {
            filme.ExibirDetalhesdoFilme();
        }

        var livros = ClientApi<Livro>.Listar(new Livro(), "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        foreach (var livro in await livros)
        {
            livro.ExibirDetalhesDoLivro();
        }

        var carros = ClientApi<Carro>.Listar(new Carro(), "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        foreach (var carro in await carros)
        {
            carro.ExibirDetalhesDoCarro();
        }

        var paises = ClientApi<Pais>.Listar(new Pais(), "https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        foreach (var pais in await paises)
        {
            pais.ExibirDetalhesDoPais();
        }

        Console.ReadKey();
    }
}