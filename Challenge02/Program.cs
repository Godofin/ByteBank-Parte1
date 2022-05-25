//Criar uma classe mostrando os valores padrões do sistema;

using bytebank;

ContaCorrente contaPadrao = new ContaCorrente();

Console.WriteLine($"Titular: {contaPadrao.titular}\n" +
    $"Conta: {contaPadrao.conta}\n" +
    $"Número Agência: {contaPadrao.numero_agencia}\n" +
    $"Nome Agência: {contaPadrao.nome_agencia}\n" +
    $"Saldo: {contaPadrao.saldo}\n" +
    $"Verificador: {contaPadrao.vaerificador}");

