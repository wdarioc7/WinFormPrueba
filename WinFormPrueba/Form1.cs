using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
          
          
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        
        }

        public object Generar()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";
          
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

       public void button2_Click(object sender, EventArgs e)
        {
            int[] Path = new int[11] { 1, 1, 0, 0, 1, 1, 0, 1, 0, 1, 1 };
            if (textBox1.Text == "")
            {
                label4.Text = "Digita un valor";
            }
            int Leap = Convert.ToInt32(textBox1.Text);
            Generar(Path,Leap);
           
        }
        public string Generar(int[] Path,int Leap)
        {
            string text = "";
            if (Leap <= 10)
            {

                if (Leap == 0)
                {
                    Leap = 1;
                }

                label3.Text = "Te encuentras actualmente en la posicion:" + Leap;
                if (Leap == 10)
                {
                    label5.Text = "Has ganado el juego - You win this Game ";

                }
                string valor = Path.GetValue(Leap).ToString();

                if (Convert.ToInt32(valor) == 1)
                {
                    label4.Text = "!!!!!!!Felicitaciones Sobreviviste :) :)";
                     text = label4.Text;
                    
                }
                else if (Convert.ToInt32(valor) == 0)
                {
                    label4.Text = "Lo siento No Sobreviviste :( :(";
                    text = label4.Text;

                }

            }
            else
            {
                label5.Text = "El valor excede el rango del arreglo";
            }


            return text;

        }
    }
}
