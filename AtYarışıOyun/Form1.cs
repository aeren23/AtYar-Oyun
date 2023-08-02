using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışıOyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatuzak, ikinciatuzak, üçüncüatuzak;
        Random rastgele=new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += rastgele.Next(5, 10);
            birinciatuzak = pictureBox1.Left;
            pictureBox2.Left += rastgele.Next(5, 10);
            ikinciatuzak= pictureBox2.Left;
            pictureBox3.Left += rastgele.Next(5, 10);
            üçüncüatuzak = pictureBox3.Left;
            if (pictureBox1.Left > pictureBox2.Left && pictureBox1.Left > pictureBox3.Left)
            {
                label6.Text = "Birinci at yarışta öne geçti";
            }
            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {
                label6.Text = "İkinci at yarışı önde götürüyor";
            }
            if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left)
            {
                label6.Text = "Üçüncü at şuan önde gidiyor";
            }
            if ((birinciatuzak + birinciatgen) >= label5.Left)
            {
                timer1.Enabled=false;
                MessageBox.Show("Birinci at galip geldi");
                label6.Text = "Birinci at galip geldi";
            }
            if ((ikinciatuzak + ikinciatgen) >= label5.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("İkinci at galip geldi");
                label6.Text = "İkinci at galip geldi";
            }
            if ((üçüncüatuzak + üçüncüatgen) >= label5.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("Üçüncü at galip geldi");
                label6.Text = "Üçüncü at galip geldi";
            }
           
        }

        int birinciatgen, ikinciatgen, üçüncüatgen;
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatuzak = pictureBox1.Left;
            ikinciatuzak = pictureBox2.Left;
            üçüncüatuzak = pictureBox3.Left;

            birinciatgen = pictureBox1.Width;
            ikinciatgen = pictureBox2.Width;
            üçüncüatgen= pictureBox3.Width;
        }

    }
}
