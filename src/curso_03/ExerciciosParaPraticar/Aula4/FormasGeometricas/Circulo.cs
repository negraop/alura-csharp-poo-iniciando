namespace Aula4.FormasGeometricas;

internal class Circulo : IForma
{
    public double Raio { get; set; }

    public double Area()
    {
        return Math.PI * Raio * Raio;
    }

    public double Perimetro()
    {
        return 2 * Math.PI * Raio;
    }
}
