using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_HW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Тази програма разбира дали числото е четно/нечетно !", "Задача 2");
            label1.Text = "Въведе избраното от вас число : ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(textBox1.Text);
                if(x == 0)
                {
                    MessageBox.Show("туй вече е спорно ма май четно", "даливе");
                }
                else if (x % 2 == 0)
                {
                    label1.Text = " Четно!";
                }
                else
                {
                    label1.Text = "Нечетно!";
                }
            }
            catch
            {
                label1.Text = "Моля въведете валиден номер!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Сигурни ли сте че искате да затворите приложението ? ", "Rly nigga?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
