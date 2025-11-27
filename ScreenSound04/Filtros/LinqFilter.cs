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
    }
}
