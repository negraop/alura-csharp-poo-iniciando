using System.Text.Json;
using ScreenSound.Filtros;
using ScreenSound.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqFilter.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex}");
    }
    
}