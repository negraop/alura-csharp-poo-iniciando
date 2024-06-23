namespace Alura.Filmes;

class Filme
{
    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<Artista> Elenco { get; set; }

    public Filme(string titulo, int duracao, List<Artista>? elenco)
    {
        if (elenco == null)
        {
            Elenco = new List<Artista>();
        }
        else
        {
            Elenco = elenco;
            foreach (var artista in Elenco)
            {
                artista.AdicionarFilme(this);
            }
        }

        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarElenco(Artista artista)
    {
        Elenco.Add(artista);
        if (!artista.FilmesAtuados.Contains(this))
        {
            artista.AdicionarFilme(this);
        }
        Console.WriteLine($"{artista} adicionado/a ao elenco.");
    }

    public void ListarElenco()
    {
        if (Elenco.Count == 0)
        {
            Console.WriteLine("Elenco vazio.");
        }
        else
        {
            Console.WriteLine("Elenco... ");
            foreach (var ator in Elenco)
            {
                Console.WriteLine(ator.Nome);
            }
        }
    }
} 
