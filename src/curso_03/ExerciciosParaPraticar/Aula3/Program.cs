using Aula3.Animal;
using Aula3.Empresa;
using Aula3.FormasGeometricas;
using Aula3.FormasGeometricasNew;

FormaGeometrica forma = new Circulo(2);
Circulo circulo = new Circulo(4);

FormaGeometricaNew forma2 = new CirculoNew(2);
CirculoNew circulo2 = new(4);

Console.WriteLine(nameof(forma));
Console.WriteLine(nameof(circulo));
Console.WriteLine(forma.GetType());
Console.WriteLine(circulo.GetType());
Console.WriteLine(forma.Area());
Console.WriteLine(forma.Perimetro());
Console.WriteLine(circulo.Area());
Console.WriteLine(circulo.Perimetro());
Console.WriteLine(); 
Console.WriteLine(nameof(forma2));
Console.WriteLine(nameof(circulo2));
Console.WriteLine(forma2.GetType());
Console.WriteLine(circulo2.GetType());
Console.WriteLine(forma2.Area);
Console.WriteLine(forma2.Perimetro);
Console.WriteLine(circulo2.Area);
Console.WriteLine(circulo2.Perimetro);



Console.WriteLine("\n******************\n");



Funcionario funcionario = new Gerente
{
    Nome = "Pedro",
    Salario = 20000.00,
    Funcional = 12345678,
    Setor = "TI"
};

Programador pedro = new()
{
    Nome = "Pedro Programmer",
    Salario = 200000.00,
    Funcional = 123456,
    LinguagemDeProgramacao = "C#"
};
Console.WriteLine(funcionario.Nome);
Console.WriteLine(funcionario.Salario);
Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.Salario);
Console.WriteLine(pedro.LinguagemDeProgramacao);



Console.WriteLine("\n******************\n");



Animal animal = new Ave();
Mamifero mamifero = new();
Peixe peixe = new();

Console.WriteLine(animal.EmitirSom());
Console.WriteLine(mamifero.EmitirSom());
Console.WriteLine(peixe.EmitirSom());