class ContaBancaria
{
    public string? Titular { get; set; }
    public int IdConta { get; set; }
    public int Senha { get; set; }
    public float Saldo { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine("INFORMAÇÕES DA CONTA");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}
