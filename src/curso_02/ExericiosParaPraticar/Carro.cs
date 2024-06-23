class Carro
{
    private int ano;
    public string? Fabricante { get; set; }
    public string? Modelo { get; set; }
    public int Ano {
        get => ano;
        set
        {
            if (value < 1960 || value > 2024)
                Console.WriteLine("Valor inválido, insira um ano entre 1960 e 2024");
            else
                ano = value;
        }
    }
    public int QuantidadePortas { get; set; }
    public int Velocidade { get; set; } = 0;
    public string DescricaoDetalhada => $"{Fabricante} {Modelo} - {Ano}";

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Informações do carro: {Fabricante} {Modelo}, {QuantidadePortas} portas, {Ano}");
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando...");
        if(Velocidade < 100){
            Velocidade = Velocidade + 5;
        }
    }

    public void Frear()
    {
        Console.WriteLine("Freando...");
        if(Velocidade > 0){
            Velocidade = Velocidade - 5;
        }
    }

    public void Buzinar()
    {
        Console.WriteLine("Bi Bi");
    }
}
