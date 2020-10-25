using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int poputki = 0;
        int min = 0, max = 101;
        Random rand = new Random();
        int pinky = 0;
        public Form1()
        {
            InitializeComponent();
            pinky = rand.Next(min, max);
            label2.Text = pinky.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(label2.Text);
            pinky = rand.Next(min, max);
            label2.Text = pinky.ToString();
            ++poputki;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            max = Convert.ToInt32(label2.Text);
            pinky = rand.Next(min, max);
            label2.Text = pinky.ToString();
            ++poputki;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Комп він вгадав твоє число(цифру) :) 1!!!1!!1\nPoputki: {poputki}","Tirania(error)");
        }
    }
}
