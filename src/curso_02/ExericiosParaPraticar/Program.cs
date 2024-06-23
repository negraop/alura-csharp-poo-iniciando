ContaBancaria conta = new ContaBancaria();
conta.idConta = 185759;
conta.titular = "Pedro";
conta.senha = 1234;
conta.saldo = 100000;

conta.ExibirInformacoes();

Console.WriteLine("\n****************\n");

Carro carro = new Carro
{
    fabricante = "GM",
    modelo = "Onix",
    ano = 2024,
    quantidadePortas = 4
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