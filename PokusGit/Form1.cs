using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokusGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo1 = int.Parse(textBox1.Text);
            int cislo2 = int.Parse(textBox2.Text);
            int soucet = cislo1 + cislo2;
            int rozdil = cislo1 - cislo2;
            int soucin = cislo1 * cislo2;
            int podil = cislo1 / cislo2;
            MessageBox.Show(soucet.ToString());
            MessageBox.Show(rozdil.ToString());
            MessageBox.Show(soucin.ToString());
            MessageBox.Show(podil.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ITA2, Aleš Dajčar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x= int .Parse(textBox3.Text);
            int faktorial = 1;
            while(x > 0)
            {
                faktorial *= x;
                --x;
            }
            MessageBox.Show(faktorial.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Přidejte button4, textbox4 a textbox5. V obstuze tlačítka naprogramujte mocninu čísla v textBox4 na číslo v textboxu5.
            int a = int.Parse(textBox4.Text);
            int b = int.Parse(textBox5.Text);
            int mocnina = 1;
            for(int i = 0; i <b; ++i)
            {
                mocnina *= a;
            }
            MessageBox.Show(mocnina.ToString());

        }
    }
}
