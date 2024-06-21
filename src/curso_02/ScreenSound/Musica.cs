using System.Reflection.Metadata.Ecma335;

class Musica
{
    public string? Nome { get; set; }
    public string? Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
    
    public string DescricaoResumidaTeste // Essa proprieade é apenas para mostrar como funcionar a alteração do getter de uma Propriedade.
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista}";
        }
    }
    public string NomeTeste // Essa propriedade é apenas para mostrar como funciona a alteração do setter de uma Propriedade.
    { 
        get => NomeTeste; 
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                Nome = value;
            }
            else
            {
                throw new ArgumentException("O nome não pode ser uma string vazia.");
            }
        }
    }
    

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
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

