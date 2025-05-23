using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hidak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var item in Form1.hidak)
            {
                if (!comboBox1.Items.Contains(item.orszag))
                {
                    comboBox1.Items.Add(item.orszag);
                }
            }
        }

        private void btnkereses_Click(object sender, EventArgs e)
        {
            foreach (var item in Form1.hidak)
            {
                if (item.orszag.Contains(comboBox1.Text))
                {
                    if (checkBox1.Checked && item.hossz > 1000)
                    {
                        richTextBox1.Text += item.hid + "\n";
                    }
                    if (!checkBox1.Checked)
                    {
                        richTextBox1.Text += item.hid + "\n";
                    }
                }
            }
        }
    }
}
