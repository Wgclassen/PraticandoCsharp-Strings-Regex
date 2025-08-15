using System.Text.RegularExpressions;

Console.WriteLine("Digite o texto:");
string texto = Console.ReadLine();
string regex = @"https?://\S+";
string textoNovo = Regex.Replace(texto, regex, "[LINK]");
Console.WriteLine(textoNovo);