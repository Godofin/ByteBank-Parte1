using bytebank;

Console.WriteLine("Boas Vindas ao seu Banco, Bytebank");

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "André Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;


Console.WriteLine($"Titular: {conta1.titular}\n" +
    $"Conta: {conta1.conta}\n" +
    $"Número Agência: {conta1.numero_agencia}\n" +
    $"Nome Agência: {conta1.nome_agencia}\n" +
    $"Saldo: {conta1.saldo}");

Console.ReadKey();