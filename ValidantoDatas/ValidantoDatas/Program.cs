using System.Text.RegularExpressions;

Console.WriteLine("Digite a data (dd/mm/aaaa):");
string data = Console.ReadLine();
string regex = @"^\d{2}/\d{2}/\d{4}$";

if (Regex.IsMatch(data, regex))
{
    Console.WriteLine("A data está no formato correto.");
} else
{
    Console.WriteLine("Formato inválido! Use dd/mm/aaaa.");
}