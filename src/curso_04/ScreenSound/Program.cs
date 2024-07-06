using System.Text.Json;
using ScreenSound.Filtros;
using ScreenSound.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // foreach(var musica in musicas)
        // {
        //     musica.ExibirDetalhesDaMusica();
        // }
        // LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        // LinqFilter.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        // LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");
        LinqFilter.FiltrarMusicasEmCSharp(musicas);


        // var musicasPreferidasDoPedro = new MusicasPreferidas("Pedro");
        // musicasPreferidasDoPedro.AdicionarMusicaFavorita(musicas[1]);
        // musicasPreferidasDoPedro.AdicionarMusicaFavorita(musicas[377]);
        // musicasPreferidasDoPedro.AdicionarMusicaFavorita(musicas[4]);
        // musicasPreferidasDoPedro.AdicionarMusicaFavorita(musicas[6]);
        // musicasPreferidasDoPedro.AdicionarMusicaFavorita(musicas[1467]);

        // musicasPreferidasDoPedro.ExibirMusicasFavoritas();

        // var musicasPreferidasDaMaria = new MusicasPreferidas("Maria");
        // musicasPreferidasDaMaria.AdicionarMusicaFavorita(musicas[100]);
        // musicasPreferidasDaMaria.AdicionarMusicaFavorita(musicas[350]);
        // musicasPreferidasDaMaria.AdicionarMusicaFavorita(musicas[40]);
        // musicasPreferidasDaMaria.AdicionarMusicaFavorita(musicas[60]);
        // musicasPreferidasDaMaria.AdicionarMusicaFavorita(musicas[727]);

        // musicasPreferidasDaMaria.ExibirMusicasFavoritas();

        // musicasPreferidasDaMaria.GerarArquivoJson();

    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex}");
    }
    
}