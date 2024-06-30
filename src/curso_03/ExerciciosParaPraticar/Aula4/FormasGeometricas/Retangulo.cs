namespace Aula4.FormasGeometricas;

public class Retangulo : IForma
{
    public double Comprimento { get; set; }
    public double Largura { get; set; }

    public double Area()
    {
        return Comprimento * Largura;
    }

    public double Perimetro()
    {
        return 2 * (Comprimento + Largura);
    }
}
