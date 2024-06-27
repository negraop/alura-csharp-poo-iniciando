namespace Aula3.FormasGeometricas;

internal class Quadrado : FormaGeometrica
{
    public double Lado { get; set; }
    
    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double Area()
    {
        return Lado * Lado;
    }

    public override double Perimetro()
    {
        return 4 * Lado;
    }
}
