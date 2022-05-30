using ByteBank3;
using ByteBank3.Titular;

Console.WriteLine("Bem vindo ao seu Banco ByteBank");


ContaCorrente conta4 = new ContaCorrente();
Cliente Sarah = new Cliente();

conta4.Titular = Sarah;
Sarah.nome = "Sarah Silva";



conta4.Saldo = 150;
Console.WriteLine($"\nSaldo: {conta4.Saldo}");
Console.WriteLine($"\nNome: {Sarah.nome}");
