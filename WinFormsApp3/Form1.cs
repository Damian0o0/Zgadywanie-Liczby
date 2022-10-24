using Microsoft.VisualBasic.Logging;
using System.Runtime.CompilerServices;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int nrpr = 0;
        int nrpr2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int losulosulosu;
            Random rand = new Random();
            if (radioButton1.Checked)
                losulosulosu = rand.Next(0, 1000);
            else if (radioButton2.Checked)
                losulosulosu = rand.Next(0, 100);
            else
                losulosulosu = rand.Next(0, 10);

            int liczba = Convert.ToInt32(textBox2.Text);
            button1.Enabled = true;
            label3.Text = "Próba numer: " + nrpr;
            nrpr++;
            textBox1.Text = nrpr.ToString();
            if (losulosulosu == liczba)
            {
                panel1.BackColor = Color.Cyan;
                label3.Text = "Trafi³eœ";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nrpr2 += 2;
            textBox1.Text = nrpr2.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label1.Text = "Trafione";
            }
            else 
            {
                label1.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}