using System.Text.RegularExpressions;

Console.WriteLine("Digite o código do cupom:");
string codigo = Console.ReadLine();
string regex = @"^\d+$";

bool valido = Regex.IsMatch(codigo, regex);

if (valido)
{
    Console.WriteLine($"O código {codigo} é válido.");
} else
{
    Console.WriteLine($"O código {codigo} não é válido.");
}