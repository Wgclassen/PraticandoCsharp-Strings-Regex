string log = "2025-03-25,Erro,Arquivo não encontrado";
var dividido = log.Split(',');
string data = dividido[0];
string erro =  dividido[1];
string mensagem = dividido[2];
Console.WriteLine(data);
Console.WriteLine(erro);
Console.WriteLine(mensagem);