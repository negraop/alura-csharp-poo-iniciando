using ScreenSound.Models;

namespace ScreenSound.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGeneros = musicas
            .Select(m => m.Genero)
            .Distinct()
            .ToList();

        Console.WriteLine("Lista de Todos os Generos Musicais:");
        foreach (var genero in todosOsGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas
            .OrderBy(m => m.Artista)
            .Select(m => m.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine("Lista de artistas ordenados:");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas
            .Where(m => m.Genero!.Contains(genero))
            .Select(m => m.Artista)
            .Distinct()
            .ToList();

        Console.WriteLine($"Lista de artistas por genero: >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas
            .Where(musica => musica.Artista!.Equals(nomeDoArtista))
            .ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }
}
