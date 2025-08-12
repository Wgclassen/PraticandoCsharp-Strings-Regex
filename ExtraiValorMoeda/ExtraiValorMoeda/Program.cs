using System.Text.RegularExpressions;

Console.WriteLine("Digite o texto do recibo:");
string recibo  = Console.ReadLine();
string regex = @"R\$ \d+,\d{2}";
string saida = Regex.Match(recibo, regex).Value;
Console.WriteLine($"Valor encontrado: {saida}");