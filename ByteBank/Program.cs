//Criando primeiras classes

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


Console.WriteLine($"Saldo pré-transferência Amanda: {conta2.saldo}");
Console.WriteLine($"Saldo pré-transferência André: {conta1.saldo}");

bool transferencia = conta1.Tranferir(50, conta2);

Console.WriteLine($"\nSaldo pós-transferência Amanda: {conta2.saldo}");
Console.WriteLine($"Saldo pós-transferência André: {conta1.saldo}");

Console.WriteLine($"Transferencia executa com sucesso? {transferencia}");





Console.ReadKey();