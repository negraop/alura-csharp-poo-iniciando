namespace Aula3.FormasGeometricas;

internal class Circulo : FormaGeometrica
{
    public double Raio { get; }
    public double Diametro => Raio * 2;
    
    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double Area()
    {
        return Math.PI * Raio * Raio;
    }

    public override double Perimetro()
    {
        return Math.PI * 2 * Raio;
    }
}
