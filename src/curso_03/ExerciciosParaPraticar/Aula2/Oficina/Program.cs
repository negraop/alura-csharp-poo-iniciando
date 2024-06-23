namespace Aula2.Oficina;

public class Program
{
    public static void Run()
    {
        // Criar instâncias de Veiculo, Cliente, Mecanico e Oficina
        Veiculo meuCarro = new Veiculo("Chevrolet", "Cruze", 2020, "ABC1234");
        Cliente cliente = new Cliente("Carlos", "987654321");
        Mecanico mecanico = new Mecanico("Mário", "Mecânica Geral");
        Oficina oficina = new Oficina();

        // Agendar e realizar um serviço na oficina
        oficina.AgendarServico(meuCarro, cliente, mecanico, "2023-12-18");
        oficina.RealizarServico(meuCarro, mecanico);
    }
}
