namespace CalculadoraReal
{
    public partial class Form1 : Form
    {
        public int resultado, numTemp;
        public string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void DigitaNumero(int num)
        {
            numTemp = (numTemp * 10) + num;
            display.Text = numTemp.ToString();

        }
        private void DigitaOperacao(string operador)
        {
            if(operacao.Length > 0)
            {
                CalculaResultado();

            }
            else
            {
                resultado = numTemp;
            }


            numTemp = 0;
            operacao = operador;
        }

        private void CalculaResultado() 
        {
            switch (operacao)
            {
                case "+":
                    resultado = resultado + numTemp;
                    break;
                case "-":
                    resultado = resultado - numTemp;
                    break;
                case "/":
                    resultado = resultado / numTemp;
                    break;
                case "x":
                    resultado = resultado * numTemp;
                    break;
            }
            display.Text = resultado.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DigitaNumero(9);
        }

        private void btn_oito_Click_1(object sender, EventArgs e)
        {
            DigitaNumero(8);
        }

        private void btn_soma_Click_1(object sender, EventArgs e)
        {
            DigitaOperacao("+");
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            DigitaOperacao("x");
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            DigitaOperacao("-");
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            DigitaOperacao("/");
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            CalculaResultado();
            
            resultado = 0;
            numTemp = 0;
            operacao = "";
        }

        private void btn_sete_Click_1(object sender, EventArgs e)
        {
            DigitaNumero(7);
        }

        private void btn_seis_Click_1(object sender, EventArgs e)
        {
            DigitaNumero(6);
        }

        private void btn_cinco_Click_1(object sender, EventArgs e)
        {
            DigitaNumero(5);
        }

        private void btn_quatro_Click_1(object sender, EventArgs e)
        {
            DigitaNumero(4);
        }

        private void btn_tres_Click_1(object sender, EventArgs e)
        {
            DigitaNumero(3);
        }

        private void btn_dois_Click_1(object sender, EventArgs e)
        {
            DigitaNumero(2);
        }

        private void btn_um_Click_1(object sender, EventArgs e)
        {
            DigitaNumero(1);
        }

        private void btn_zero_Click_1(object sender, EventArgs e)
        {
            DigitaNumero(0);
        }

        private void btn_limpa_Click(object sender, EventArgs e)
        {
            
            display.Clear();
            resultado = 0;
            numTemp = 0;
            operacao = "";

        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            numTemp = 0;
        }
    }
}