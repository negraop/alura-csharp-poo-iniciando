namespace Aula2.PetShop;

class Program
{
    public static void Run()
    {
        Dono dono = new("Laura", "1122334455");
        Pet mike = new("Mikinho", 8, "Cachorro");
        Medico veterinario = new("Dr. Pedro", "Veterinario");
        Consulta consulta = new(mike, dono, veterinario, "23-01-25");

        Console.WriteLine($"{consulta.DataConsulta}");
    }
}
