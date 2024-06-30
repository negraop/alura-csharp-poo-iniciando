namespace Aula4.Notificacao;

internal class Email : INotificavel
{
    public string? EnderecoDeEmail { get; set; }
    
    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando e-mail para {EnderecoDeEmail}");
    }
}
