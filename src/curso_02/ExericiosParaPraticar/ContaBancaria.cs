class ContaBancaria
{
    public string? titular { get; set; }
    public int idConta { get; set; }
    public int senha { get; set; }
    public float saldo { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine("INFORMAÇÕES DA CONTA");
        Console.WriteLine($"Titular: {titular}");
        Console.WriteLine($"Saldo: {saldo}");
    }
}
