string palavraChave = "C#";
Console.WriteLine($"A palavra chave é: {palavraChave}");
Console.WriteLine("Digite um texto:");
string textoDigitado = Console.ReadLine();
if (textoDigitado.Contains(palavraChave))
{
    Console.WriteLine("A palavra-chave foi encontrada na pesquisa.");
} else
{
    Console.WriteLine("A palavra-chave não foi encontrada.");
}