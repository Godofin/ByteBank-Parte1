using ByteBank3.Titular;

namespace ByteBank3
{
    public class ContaCorrente
    {
        public Cliente Titular{ get; set; }
        public string nome_agencia { get; set; }
        public int numero_agencia{ get; set; }
        public string conta { get; set; }
        private double saldo { get; set; }
        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo += value;
                }
            }
        }


        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                Console.WriteLine("O valor não pode ser sacado, pois o saldo é menor que o valor do saque!");
                return false;
            }
            else if (valor < 0)
            {
                Console.WriteLine("Não se pode realizar saques negativos!");
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Tranferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }

        }

        
    }
}