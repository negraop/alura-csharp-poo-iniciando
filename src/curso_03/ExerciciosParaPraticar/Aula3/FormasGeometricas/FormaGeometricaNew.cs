namespace Aula3.FormasGeometricasNew;

public abstract class FormaGeometricaNew
{
    public abstract double Area { get; }
    public abstract double Perimetro { get; }
}

public class RetanguloNew : FormaGeometricaNew
{
    public double Largura { get; }
    public double Altura { get; }

    public RetanguloNew(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public override double Area
    {
        get { return Largura * Largura; }
    }

    public override double Perimetro
    {
        get { return 2 * (Largura + Altura); }
    }
}

public class CirculoNew : FormaGeometricaNew
{
    public double Raio { get; set; }

    public CirculoNew(double raio)
    {
        Raio = raio;
    }

    public override double Area
    {
        get { return Math.PI * Raio * Raio; }
    }

    public override double Perimetro
    {
        get { return 2 * Math.PI * Raio; }
    }
}
