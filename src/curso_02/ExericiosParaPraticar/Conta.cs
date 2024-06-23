class Titular
{
    public string? Nome { get; set; }
    public string? Cpf { get; set; }
    public string? Endereco { get; set; }
    public Titular(string? nome, string? cpf, string? endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
}

class Conta
{
    public Titular? Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double Limite { get; set; }

    public string Informacoes =>
        $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular?.Nome} - Saldo: {this.Saldo}";
    
    public Conta(Titular? titular, int agencia, int numeroDaConta, double limite)
    {
        Titular = titular;
        Agencia = agencia;
        NumeroDaConta = numeroDaConta;
        Saldo = 0;
        Limite = limite;
    }
}
