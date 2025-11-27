using System.Text.Json;

namespace ScreenSound04.Modelos
{
    internal class MusicasPreferidas
    {
        public string? Nome { get; set; }
        public List<Musica> ListaDeMusicasFavoritas;

        public MusicasPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusica(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Músicas favoritas de {Nome}:");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine($"- {musica.Nome} por {musica.Artista}");
            }
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new 
            {
                nome = Nome,
                musicasFavoritas = ListaDeMusicasFavoritas
            });

            string nomeArquivo = $"{Nome}_musicas_favoritas.json";

            File.WriteAllText(nomeArquivo, json);
            Console.WriteLine($"Arquivo JSON gerado: {nomeArquivo} - {Path.GetFullPath(nomeArquivo)}");
        }
    }
}
