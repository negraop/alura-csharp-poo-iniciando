class Produto
{
    private float preco;
    private int estoque;
    public string? Nome { get; set; }
    public string? Marca { get; set; }
    public float Preco {
        get => preco;
        set
        {
            if (value <= 0)
                Console.WriteLine("O preço deve ser um valor positivo");
            else
                preco = value;
        } 
    }
    public int Estoque {
        get => estoque;
        set
        {
            if (value <= 0)
                Console.WriteLine("O estoque deve ser um valor positivo");
            else
                estoque = value;
        }
    }

    public string DescricaoDetalhada => $"{Nome} {Marca} - R${Preco} - {Estoque}un";

}
