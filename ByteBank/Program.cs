using bytebank;

Console.WriteLine("Boas Vindas ao seu Banco, Bytebank");

ContaCorrente conta1 = new ContaCorrente();
ContaCorrente conta2 = new ContaCorrente();

conta1.titular = "André Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

conta2.titular = "Amanda Nogueira";
conta2.conta = "10106-x";
conta2.numero_agencia = 23;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;


Console.WriteLine($"Saldo da Amanda pré-saque {conta2.saldo} ");
bool saque = conta2.Sacar(50);
Console.WriteLine($"Saque realizado? {saque}");
Console.WriteLine($"Saldo da Amanda pós-saque {conta2.saldo} ");
conta2.Depositar(60);
Console.WriteLine($"O Saldo da Amanda pós-depósito é de: {conta2.saldo}");


Console.ReadKey();