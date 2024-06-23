class Musica
{
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero? Genero { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    public string DescricaoResumidaTeste // Essa proprieade é apenas para mostrar como funcionar a alteração do getter de uma Propriedade.
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista}";
        }
    }

    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no planos");
        } else 
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    public override string ToString()
    {
        return $"Nome: {Nome}\nArtista: {Artista}\n";
    }
}

