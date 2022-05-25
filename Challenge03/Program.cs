//Já sabemos o que são tipo de valor, referência e valor padrão de campos no .NET. 
//Sendo assim, imagine que você precisa cadastrar uma pessoa num sistema médico. 
//Para isso, será necessário criar uma classe Pessoa com os campos referentes ao nome, idade, altura, peso 
//de cada paciente e por fim exibir no Program.cs o valor padrão de cada um dos campos.

using hospital;

Pessoa pessoa1 = new Pessoa();

Console.WriteLine($"O nome do paciente é: {pessoa1.nome}\n" +
    $"A idade do paciente é de: {pessoa1.idade} anos\n" +
    $"A altura da pessoa é de: {pessoa1.altura} metros\n" +
    $"O peso da pessoa é de: {pessoa1.peso} Kg");
