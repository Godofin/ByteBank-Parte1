using bytebank;

Console.WriteLine("Boas Vindas ao seu Banco, Bytebank");

ContaCorrente conta1 = new ContaCorrente();
ContaCorrente conta2 = new ContaCorrente();

conta1.titular = "André Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

conta2.titular = "André Silva";
conta2.conta = "10123-x";
conta2.numero_agencia = 23;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

conta1 = conta2;

Console.WriteLine(conta1==conta2);


Console.ReadKey();