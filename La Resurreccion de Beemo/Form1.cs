using System.Collections;

namespace La_Resurreccion_de_Beemo
{
    public partial class Form1 : Form
    {
        String texto = "";
        String numero = "";
        ArrayList numeros = new ArrayList();
        ArrayList operadores = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto + 0;
            numero = numero + 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reglas())
            {
            label1.Text = texto = texto + ".";
            numero = numero + ".";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto + 1;
            numero = numero + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto + 2;
            numero = numero + 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto + 3;
            numero = numero + 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto + 4;
            numero = numero + 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto + 5;
            numero = numero + 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto + 6;
            numero = numero + 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto + 7;
            numero = numero + 7;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto + 8;
            numero = numero + 8;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto + 9;
            numero = numero + 9;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = texto = texto.Substring(0, texto.Length - 1);
            if (reglas())
            {
                numero = numero.Substring(0, numero.Length - 1);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = texto = "";
            numero = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (reglas())
            {
                label1.Text = texto = texto + "/";
                numeros.Add(Double.Parse(numero));
                numero = "";
                operadores.Add('/');
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (reglas())
            {
                label1.Text = texto = texto + "*";
                numeros.Add(Double.Parse(numero));
                numero = "";
                operadores.Add('*');
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (reglas())
            {
                label1.Text = texto = texto + "-";
                numeros.Add(Double.Parse(numero));
                numero = "";
                operadores.Add('-');
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (reglas())
            {
                label1.Text = texto = texto + "+";
                numeros.Add(Double.Parse(numero));
                numero = "";
                operadores.Add('+');
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Boolean operacionT2 = true;
            Boolean operacionT1 = false;
            while (numeros.Count > 1)
            {

                while (operacionT2)
                {
                    foreach (Char operador in operadores){
                        Double numero;
                        if(operador == '/')
                        {

                        }
                    }
                }
            }
        }
        private Boolean reglas()
        {
            int numTex = texto.Length - 1;
            if (texto[numTex].Equals('/')){
                return false;
            } else if (texto[numTex].Equals('*'))
            {
                return false;
            }
            else if (texto[numTex].Equals('+'))
            {
                return false;
            }
            else if (texto[numTex].Equals('+'))
            {
                return false;
            }
            else if (texto[numTex].Equals('.'))
            {
                return false;
            }else
            {
                return true;
            }
        }
    }
}