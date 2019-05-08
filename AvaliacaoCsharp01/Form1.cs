using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvaliacaoCsharp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float partialResult;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valueItemOne, quantityItemOne, valueItemTwo, quantityItemTwo;

            valueItemOne = Convert.ToInt32(textBox1.Text);
            quantityItemOne = Convert.ToInt32(textBox2.Text);

            valueItemTwo = Convert.ToInt32(textBox3.Text);
            quantityItemTwo = Convert.ToInt32(textBox4.Text);

            partialResult = ((valueItemOne * quantityItemOne) + (valueItemTwo * quantityItemTwo));

            if(partialResult >= 10)
            {
                result.Text = Convert.ToString(partialResult * 0.9);
            }
            else
            {
                result.Text = Convert.ToString(partialResult * 0.95);
            }
        }
    }
}
