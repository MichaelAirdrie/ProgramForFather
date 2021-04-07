using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paper_Stuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add(300);
            comboBox1.Items.Add(89);
            comboBox1.Text = "300";

            comboBox2.Items.Add(8.5);
            comboBox2.Items.Add(11);
            comboBox2.Items.Add(12);
            comboBox2.Text = "8.5";

            comboBox3.Items.Add(11);
            comboBox3.Items.Add(17);
            comboBox3.Items.Add(18);
            comboBox3.Text = "11";

            comboBox4.Items.Add(1000);
            comboBox4.Items.Add(750);
            comboBox4.Items.Add(500);
            comboBox4.Items.Add(250);
            comboBox4.Items.Add(1);
            comboBox4.Text = "1000";


        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Double.TryParse(comboBox1.Text, out Double result);
            Double gsm = result;
            Double.TryParse(comboBox2.Text, out Double result1);
            Double width = result1;
            Double.TryParse(comboBox3.Text, out Double result2);
            Double height = result2;
            Double.TryParse(comboBox4.Text, out Double result3);
            Double sheets = result3;
            textBox1.Text = (gsm * (width / 39.3700787) * (height / 39.3700787) * sheets).ToString();
            textBox2.Text = ((gsm * (width / 39.3700787) * (height / 39.3700787) * sheets) * 0.0022046226216).ToString();
        }
        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Double.TryParse(comboBox1.Text, out Double result);
            Double gsm = result;
            Double.TryParse(comboBox2.Text, out Double result1);
            Double width = result1;
            Double.TryParse(comboBox3.Text, out Double result2);
            Double height = result2;
            Double.TryParse(comboBox4.Text, out Double result3);
            Double sheets = result3;
            textBox1.Text = (gsm * (width / 39.3700787) * (height / 39.3700787) * sheets).ToString();
            textBox2.Text = ((gsm * (width / 39.3700787) * (height / 39.3700787) * sheets) * 0.0022046226216).ToString();
        }
        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Double.TryParse(comboBox1.Text, out Double result);
            Double gsm = result;
            Double.TryParse(comboBox2.Text, out Double result1);
            Double width = result1;
            Double.TryParse(comboBox3.Text, out Double result2);
            Double height = result2;
            Double.TryParse(comboBox4.Text, out Double result3);
            Double sheets = result3;
            textBox1.Text = (gsm * (width / 39.3700787) * (height / 39.3700787) * sheets).ToString();
            textBox2.Text = ((gsm * (width / 39.3700787) * (height / 39.3700787) * sheets) * 0.0022046226216).ToString();
        }
        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Double.TryParse(comboBox1.Text, out Double result);
            Double gsm = result;
            Double.TryParse(comboBox2.Text, out Double result1);
            Double width = result1;
            Double.TryParse(comboBox3.Text, out Double result2);
            Double height = result2;
            Double.TryParse(comboBox4.Text, out Double result3);
            Double sheets = result3;
            textBox1.Text = (gsm * (width / 39.3700787) * (height / 39.3700787) * sheets).ToString();
            textBox2.Text = ((gsm * (width / 39.3700787) * (height / 39.3700787) * sheets) * 0.0022046226216).ToString();
        }
    }
}
