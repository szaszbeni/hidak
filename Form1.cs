using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hidak
{
    public partial class Form1 : Form
    {
        public static List<Fuggohid> hidak = new List<Fuggohid>();
        public Form1()
        {
            InitializeComponent();
        }


        public class Fuggohid
        {
            public int helyezes { get; set; }
            public string hid { get; set; }
            public string hely { get; set; }
            public string orszag { get; set; }
            public int hossz { get; set; }
            public string adat { get; set; }

            public Fuggohid(string row)
            {
                string[] parts = row.Split('\t');
                helyezes = int.Parse(parts[0]);
                hid = parts[1];
                hely = parts[2];
                orszag = parts[3];
                hossz = int.Parse(parts[4]);
                adat = parts[5];
            }
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fuggohidak.csv");
            string FirstLine = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Fuggohid hid = new Fuggohid(sr.ReadLine());
                hidak.Add(hid);
            }

            foreach (var item in hidak)
            {
                listBox1.Items.Add(item.hid);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbhely.Text = hidak[listBox1.SelectedIndex].hely;
            tborszag.Text = hidak[listBox1.SelectedIndex].orszag;
            tbhossz.Text = hidak[listBox1.SelectedIndex].hossz.ToString();
            tbev.Text = hidak[listBox1.SelectedIndex].ev;
        }
    }
}
