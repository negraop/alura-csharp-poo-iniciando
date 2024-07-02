using System.Text.Json;
using ScreenSound.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        Console.WriteLine(musicas.Count);
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex}");
    }
    
}