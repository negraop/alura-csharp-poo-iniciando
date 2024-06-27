namespace Aula3.FormasGeometricas;

internal class Triangulo : FormaGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double baseTriangulo, double altura)
    {
        Base = baseTriangulo;
        Altura = altura;
    }

    public override double Area()
    {
        return Base * Altura / 2;
    }

    public override double Perimetro()
    {
        return Base + Altura + Math.Sqrt(Base * Base + Altura * Altura);
    }
}
