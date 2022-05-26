namespace bytebank
{
    public class ContaCorrente
    {
        public string nome;
        public string conta;
        public int numeroAgencia;
        public string nomeAgencia;
        public double saldo;

        public void Exibir(ContaCorrente contaAExibir)
        {
            Console.WriteLine("------Informações da conta corrente------");
            Console.WriteLine($"Nome do titular: {contaAExibir.nome}\n" +
                $"Número da conta: {contaAExibir.conta}\n" +
                $"Número da agência: {contaAExibir.numeroAgencia}\n" +
                $"Nome da Agência Bancária: {contaAExibir.nomeAgencia}\n" +
                $"Saldo em conta: R${contaAExibir.saldo}");
        }
    }
}