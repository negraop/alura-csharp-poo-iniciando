using System.Runtime.InteropServices;

Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();


Console.WriteLine("\n*********************\n");


Episodio episodio1 = new Episodio("O Começo do Podcast", 1, 3600);
Episodio episodio2 = new Episodio("Metade do Podcast", 2, 3000);
Episodio episodio3 = new Episodio("O Fim do Podcast", 3, 4000);

episodio1.AdicionarConvidados("Carioca");
episodio1.AdicionarConvidados("Serjão foguetes");

episodio2.AdicionarConvidados("Cariani");
episodio2.AdicionarConvidados("Casemiro");
episodio2.AdicionarConvidados("Coringa");

episodio3.AdicionarConvidados("Pedro Loos");

Podcast podcast = new Podcast("Spotify", "Podpahh");
podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.AdicionarEpisodio(episodio3);

podcast.ExibirDetalhes();