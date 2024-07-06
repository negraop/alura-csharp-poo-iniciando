using System.Text.Json.Serialization;

namespace ScreenSound.Models;

internal class Musica
{
    private List<string> tonalidades = ["C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"];

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string? Tonalidade { 
        get
        {
            return tonalidades[Key];
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Artista: {Duracao / 1000}s");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
        Console.WriteLine($"Key: {Key}");
        Console.WriteLine();
    }
}
