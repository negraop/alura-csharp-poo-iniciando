class Episodio
{
    private List<string> listaConvidados = new List<string>();
    public string Titulo { get; }
    public int Ordem { get; }
    public int Duracao { get; }
    public string Resumo 
    {
        get
        {
            string resumo = $"Episodio {Ordem}: {Titulo} - {Duracao}s\n";
            foreach (string convidado in listaConvidados)
            {
                resumo += $"Convidado: {convidado}\n";
            }
            return resumo;
        }
    }

    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        listaConvidados.Add(convidado);
    }
}
