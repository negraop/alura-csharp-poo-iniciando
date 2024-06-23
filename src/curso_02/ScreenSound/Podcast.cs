class Podcast
{
    private List<Episodio> episodios = new();
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Host: {Host} - Nome: {Nome}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
    }
}
