using Alura.Filmes;
using VideoA = VideoFlix.PlataformaA.Video;
using VideoB = VideoFlix.PlataformaB.Video;

Artista timRobbins = new("Tim Robbins", 55);
Artista morganFreeman = new("Morgan Freema", 80);
Artista marlonBrando = new("Marlon Brando", 85);
Artista alPacino = new("Al Pacino", 84);
Artista christianBale = new("ChristianBale", 60);
Artista heatherLedge = new("Tim Robbins", 27);
Artista elijahWood = new("Elijah Wood", 55);
Artista viggoMortensen = new("Viggo Mortensen", 65);

Filme filme = new Filme("Um sonho de liberdade", 142, new List<Artista>() { timRobbins, morganFreeman });
Filme filme2 = new Filme("O poderoso chefão", 175, new List<Artista>() { marlonBrando, alPacino });
Filme filme3 = new Filme("Batman - O Cavaleiro das Trevas", 152, new List<Artista>() { christianBale, heatherLedge });
Filme filme4 = new Filme("Senhor dos Anéis - O Retorno do Rei", 201, new List<Artista>() { elijahWood });
Filme filme5 = new Filme("Green Book - O Guia", 130, new List<Artista>() { viggoMortensen });

List<Filme> meusFilmesFavoritos =  new List<Filme>();
meusFilmesFavoritos.Add(filme);
meusFilmesFavoritos.Add(filme2);
meusFilmesFavoritos.Add(filme3);
meusFilmesFavoritos.Add(filme4);
meusFilmesFavoritos.Add(filme5);

foreach(Filme f in meusFilmesFavoritos)
{
    Console.WriteLine($"Filme: {f.Titulo}");
    Console.WriteLine($"Duracao: {f.Duracao}");
    f.ListarElenco();
    Console.WriteLine();
}

Console.WriteLine("\n***************\n");

VideoA video = new();
VideoB video2 = new();