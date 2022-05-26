//Aprendendo packages e métodos

using ByteBank2;
using ByteBank2.Titular;

ContaCorrente conta1 = new ContaCorrente();
//Cliente sara = new Cliente();

//sara.nome = "André Silva";
//sara.cpf = "12345678978";
//sara.profissao = "Desenvolvedor C#";



conta1.titular = new Cliente();

conta1.titular.nome = "André Silva";
conta1.titular.cpf = "40028922";
conta1.titular.profissao = "Desenvolvedor C#";
conta1.conta = "124567-x";
conta1.numero_agencia = 42;
conta1.nome_agencia = "Agência Central";

//Console.WriteLine(sara.nome);
//Console.WriteLine(conta1.titular.nome);

if(conta1.titular == null)
{
    Console.WriteLine("O campo titular está nulo");
}