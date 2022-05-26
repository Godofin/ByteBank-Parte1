//Agora seu desafio é criar um método na classe ContaCorrenteque 
//exiba todas as informações da conta no console da aplicação. Topa praticar?

using bytebank;

ContaCorrente conta1 = new ContaCorrente();

conta1.nome = "Guilherme Lavezzo";
conta1.conta = "400289-22";
conta1.numeroAgencia = 42;
conta1.nomeAgencia = "BytePay";
conta1.saldo = 10000000;

conta1.Exibir(conta1);
