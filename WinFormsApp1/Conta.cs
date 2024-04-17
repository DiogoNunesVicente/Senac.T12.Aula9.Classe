namespace WinFormsAppClasse

{

    // classe ( visibilidade, tipo, nome)

    public class Conta

    {

        // propriedade (visibilida, tipo nome)

        public int NumeroConta { get; set; }

        public string Nome { get; set; }

        public decimal Saldo { get; set; }

        public void Sacar( decimal valor)
        {
            Saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor  ;
        }
    }

}