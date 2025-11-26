

//O Http Client é usado para fazer requisições HTTP em C# e permite enviar e receber dados de servidores web.
using (HttpClient client = new HttpClient())
{
	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
    }
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
	}
}


Console.ReadKey();
