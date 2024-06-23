class Carro
{
    public string? fabricante;
    public string? modelo;
    public int ano;
    public int quantidadePortas;
    public int velocidade = 0;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Informações do carro: {this.fabricante} {this.modelo}, {this.quantidadePortas} portas, {this.ano}");
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando...");
        if(velocidade < 100){
            velocidade = velocidade + 5;
        }
    }

    public void Frear()
    {
        Console.WriteLine("Freando...");
        if(velocidade > 0){
            velocidade = velocidade - 5;
        }
    }

    public void Buzinar()
    {
        Console.WriteLine("Bi Bi");
    }
}
