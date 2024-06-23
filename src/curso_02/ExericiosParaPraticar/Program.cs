ContaBancaria conta = new ContaBancaria();
conta.IdConta = 185759;
conta.Titular = "Pedro";
conta.Senha = 1234;
conta.Saldo = 100000;

conta.ExibirInformacoes();

Console.WriteLine("\n****************\n");

Carro carro = new Carro
{
    Fabricante = "GM",
    Modelo = "Onix",
    Ano = 2024,
    QuantidadePortas = 4
};

carro.Acelerar();
carro.Acelerar();
carro.Acelerar();
carro.Acelerar();
carro.ExibirInformacoes();
carro.Frear();
carro.Frear();
carro.ExibirInformacoes();
carro.Buzinar();

Console.WriteLine("\n****************\n");

Produto produto = new Produto
{
    Nome = "Colírio",
    Marca = "SeeCorp",
    Preco = 10.75f,
    Estoque = 13
};

Console.WriteLine(produto.Descricao);

Console.WriteLine("\n****************\n");

Titular titular = new Titular("George Harrison", "000.000.000-00", "Rua dos Besouros, Liverpool");
Conta c = new Conta(titular, 1, 2234, 100000);

Console.WriteLine(c.Informacoes);

Console.WriteLine("Informações do Titular: ");
Console.WriteLine($"Nome: {c.Titular?.Nome}");
Console.WriteLine($"CPF: {c.Titular?.Cpf}");
Console.WriteLine($"Endereco: {c.Titular?.Endereco}");


Console.WriteLine("\n****************\n");

EstoqueDeProdutos estoque = new();
estoque.AdicionarProduto(produto);
estoque.ExibirProdutos();