using System.Text.RegularExpressions;

Console.WriteLine("Digite sua frase:");
string entrada = Console.ReadLine();
string mensagem = Regex.Replace(entrada, @"\s+", " ").Trim();
Console.WriteLine(mensagem);