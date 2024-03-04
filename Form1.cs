using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kg, cm, age;//deklarisemo dve promenljive koje ce preuzeti vrednosti iz textBox1 i textBox2
            kg = Double.Parse(textBox1.Text);//funkcija Double.Parse() konvertuje string u broj
            cm = Double.Parse(textBox2.Text);
            age = Double.Parse(textBox4.Text);
            textBox3.Text = ((10 * kg) + (6.25 * cm) - (5 * age) + 5).ToString();//funkcija ToString() konvertuje broj u string
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
