using bytebank;

Console.WriteLine("Boas Vindas ao seu Banco, Bytebank");

ContaCorrente conta1 = new ContaCorrente();
ContaCorrente conta2 = new ContaCorrente();
ContaCorrente conta3 = new ContaCorrente();

conta1.titular = "André Silva";
conta1.conta = "10123-x";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

conta2.titular = "Amanda Silva";
conta2.conta = "111999-x";
conta2.numero_agencia = 58;
conta2.nome_agencia = "Agência Central";
conta2.saldo = 100;

//Console.WriteLine($"Titular: {conta1.titular}\n" +
//    $"Conta: {conta1.conta}\n" +
//    $"Número Agência: {conta1.numero_agencia}\n" +
//    $"Nome Agência: {conta1.nome_agencia}\n" +
//    $"Saldo: {conta1.saldo}");

Console.WriteLine($"Titular: {conta3.titular}\n" +
    $"Conta: {conta3.conta}\n" +
    $"Número Agência: {conta3.numero_agencia}\n" +
    $"Nome Agência: {conta3.nome_agencia}\n" +
    $"Saldo: {conta3.saldo}\n" +
    $"Verificador: {conta3.vaerificador}");

Console.ReadKey();