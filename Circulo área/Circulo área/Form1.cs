using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circulo_área
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Area area = new Area();
            double radio = Convert.ToDouble(textBox1.Text);
            label2.Text = area.Areadelcirculo(float.Parse(textBox1.Text)).ToString();



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
