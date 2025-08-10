Console.WriteLine("Digite o nome do cliente:");
string nomeCliente = Console.ReadLine();
Console.WriteLine("Digite o endereço:");
string enderecoCliente = Console.ReadLine();
Console.WriteLine("Digite o valor do frete:");
string valorFrete =  Console.ReadLine();
Console.WriteLine("Digite a data de entrega:");
string dataEntrega = Console.ReadLine();

Console.WriteLine("\n========== RELATÓRIO DE ENTREGA ==========\n");
Console.WriteLine($"Cliente: {nomeCliente}");
Console.WriteLine($"Endereço: {enderecoCliente}");
Console.WriteLine($"Valor do frete: {valorFrete}");
Console.WriteLine($"Data: {dataEntrega}");
Console.WriteLine("\n==========================================");