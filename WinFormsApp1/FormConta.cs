using WinFormsAppClasse;

namespace WinFormsApp1
{
    public partial class FormConta : Form
    {
        Conta conta = new Conta();
        public FormConta()
        {
            InitializeComponent();
            //ativar o botão sacar
            btnSacar.Enabled = false;
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            conta = new Conta();
            // determinei atributos do objeto conta
            conta.NumeroConta = int.Parse(txtNumeroConta.Text);
            conta.Nome = txtTitularConta.Text;
            conta.Depositar(100);

            // eu vou carregar o list box com os dados da conta
            string dadosConta = " Numero: " + conta.NumeroConta + " Titular: " + conta.Nome + " Saldo: " + conta.Saldo;

            listBox1.Items.Add(dadosConta);


        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            // se a string txt.Valor.Text está nula ou vazia
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                txtValor.Focus();
                MessageBox.Show("prencha o valor do deposito");
                return;
            }
            //criar uma variavel para obter o valor a ser depositado
            decimal valorADepositar = decimal.Parse(txtValor.Text);

            //chama o metodo depositar da classe conta
            conta.Depositar(valorADepositar);

            //monta uma string chamada dados conta com o saldo atualizado
            string dadosConta = " Numero: " + conta.NumeroConta + " Titular: " + conta.Nome + " Saldo: " + conta.Saldo;

            //adiciona um item novo no listBox
            listBox1.Items.Add(dadosConta);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            decimal valorASacar = decimal.Parse(txtValor.Text);
            conta.Sacar(valorASacar);
            string dadosConta = " Numero: " + conta.NumeroConta + " Titular: " + conta.Nome + " Saldo: " + conta.Saldo;

            listBox1.Items.Add(dadosConta);
        }

        private void txtValor_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValor.Text))
            {
                btnSacar.Enabled = true;
            }
            else {
                btnSacar.Enabled = false;
            }
        }
    }
}
