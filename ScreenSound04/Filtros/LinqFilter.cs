using ScreenSound04.Modelos;

namespace ScreenSound04.Filtros
{
    internal class LinqFilter
    {
        public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
        {            
            var todoOsGenerosMusicais = musicas.Select(genero => genero.Genero).Distinct().ToList();

            foreach (var genero in todoOsGenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string generoMusical)
        {
            var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(generoMusical)).Select(musica => 
            musica.Artista).Distinct().ToList();
            
            Console.WriteLine($"Músicas do gênero {generoMusical}:");
            foreach (var artista in artistasPorGeneroMusical)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
        {
            var musicasPorArtista = musicas.Where(musica => musica.Artista.Contains(artista)).ToList();
            
            foreach (var musica in musicasPorArtista)
            {
                Console.WriteLine($" Artista - {musica.Artista} - Música - {musica.Nome}");
            }
        }
    }
}
