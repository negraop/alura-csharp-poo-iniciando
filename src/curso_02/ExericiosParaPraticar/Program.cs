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

Titular t = new();
Conta c = new();

t.Nome = "George Harrison";
t.Cpf = "000.000.000-00";
t.Endereco = "Rua dos Besouros - Liverpool";

c.Titular = t;
c.Agencia = 1;
c.NumeroDaConta = 2234;
c.Saldo = 10000000.0;
c.Limite = 100000.0;

Console.WriteLine("Informações do Titular: ");
Console.WriteLine($"Nome: {c.Titular.Nome}");
Console.WriteLine($"CPF: {c.Titular.Cpf}");
Console.WriteLine($"Endereco: {c.Titular.Endereco}");


Console.WriteLine("\n****************\n");

EstoqueDeProdutos estoque = new();
estoque.AdicionarProduto(produto);
estoque.ExibirProdutos();