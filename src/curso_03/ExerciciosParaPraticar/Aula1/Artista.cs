namespace Alura.Filmes;

class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> FilmesAtuados { get; set; }
    public int QuantidadeDeFilmes => FilmesAtuados.Count;
    
    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>(); 
    }


    public void AdicionarFilme(Filme filme)
    {
        FilmesAtuados.Add(filme);
        if(!filme.Elenco.Contains(this)) filme.AdicionarElenco(this);
    }

    public void MostrarFilmesAtuados(){

        if(FilmesAtuados.Count == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado na base para {Nome}");
            return;
        }

        Console.WriteLine($"Filmes de {Nome}...");
        foreach(var filme in FilmesAtuados)
        {
            Console.WriteLine($"Filme: {filme.Titulo}");
        }
    }
}
