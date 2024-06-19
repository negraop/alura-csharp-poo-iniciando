// 01 - Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
Console.WriteLine("\n1) *********************\n");
Dictionary<string, List<int>> alunos = new Dictionary<string, List<int>> {
    { "Pedro", new List<int> { 10, 9, 9 } },
    { "Laura", new List<int> { 10, 10, 10 } }
};

foreach (var aluno in alunos)
{
    double media = aluno.Value.Average();
    Console.WriteLine($"O aluno(a) {aluno.Key} tem uma média de {media}");
}

// 02 - Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
Console.WriteLine("\n2) *********************\n");
Dictionary<string, int> produtos = new Dictionary<string, int> {
    { "calçado", 50 },
    { "roupa", 30 },
    { "chapéu", 10 }
};

string nomeProduto = "calçado";


if (produtos.ContainsKey(nomeProduto))
{
    Console.WriteLine($"O produto {nomeProduto} possui {produtos[nomeProduto]} quantidades.");
} else
{
    Console.WriteLine($"O produto {nomeProduto} não foi encontrado");
}

// 03 - Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
Console.WriteLine("\n3) *********************\n");
Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
{
    { "Qual é a capital do Brasil?", "Brasília" },
    { "Quanto é 7 vezes 8?", "56" },
    { "Quem escreveu 'Romeu e Julieta'?", "William Shakespeare" },
};

int pontuacao = 0;

foreach(var pergunta in perguntasERespostas) 
{
    Console.WriteLine(pergunta.Key);
    Console.Write("Sua resposta: ");
    string respostaUsuario = Console.ReadLine()!;

    if (respostaUsuario.ToLower() == pergunta.Value.ToLower())
    {
        Console.WriteLine("Correto!\n");
        pontuacao++;
    }
    else
    {
        Console.WriteLine($"Incorreto. A resposta correta é: {pergunta.Value}\n");
    }
}

Console.WriteLine($"Pontuação final: {pontuacao} de {perguntasERespostas.Count}");