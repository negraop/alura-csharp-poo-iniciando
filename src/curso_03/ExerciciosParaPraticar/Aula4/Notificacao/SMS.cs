namespace Aula4.Notificacao;

internal class SMS : INotificavel
{
    public string? NumeroTelefone { get; set; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando SMS para {NumeroTelefone}");
    }
}
