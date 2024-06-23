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

    public string Descricao => $"{Nome} {Marca} - R${Preco} - {Estoque}un";

}


class EstoqueDeProdutos
{
    private List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add((produto));
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque");
    }

    public void ExibirProdutos()
    {
        if(produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        }else
        {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach(var produto in produtos){
                Console.WriteLine(produto.Descricao);
            }
        }
    }
}
