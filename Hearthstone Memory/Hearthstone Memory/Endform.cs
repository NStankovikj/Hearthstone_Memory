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
using System.Runtime.InteropServices;
using System.Threading;
using System.Media;
using System.Reflection;
using System.Security.Cryptography;
//IF THERE IS ANY ERROR, DELETE THE RELEASE/DEBUG AND TRY AGAIN !
//IF THERE IS ANY ERROR, DELETE THE RELEASE/DEBUG AND TRY AGAIN !
//IF THERE IS ANY ERROR, DELETE THE RELEASE/DEBUG AND TRY AGAIN !
//IF THERE IS ANY ERROR, DELETE THE RELEASE/DEBUG AND TRY AGAIN !
//IF THERE IS ANY ERROR, DELETE THE RELEASE/DEBUG AND TRY AGAIN !
namespace Hearthstone_Memory
{
    public partial class Endform : Form
    {
       public Hig endh = new Hig();
        
        public Endform()
        {
            InitializeComponent();
            
        }

        private void Endform_Load(object sender, EventArgs e)
        {
            int summ = endh.pts + endh.bon;
            label1.Text = "Congrats, you scored: " + summ.ToString() + " points!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Endform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            Application.Exit();
            
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            endh.EncryptFile(@".\Resources/bacs1_x#11.txt", @".\Resources/bacs1_x#111.txt");
            File.Delete(@".\Resources/bacs1_x#11.txt");
            timer4.Start();
            
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            Application.Restart();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            endh.EncryptFile(@".\Resources/bacs1_x#11.txt", @".\Resources/bacs1_x#111.txt");
            File.Delete(@".\Resources/bacs1_x#11.txt");
            timer2.Start();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == ' ') e.Handled = true;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                endh.name = "Unknown";
            }
            else
            {
                endh.name = textBox1.Text;
            }

            int summ = endh.pts + endh.bon;
            endh.highsc.Add(Tuple.Create(endh.name, summ));
            endh.DecryptFile(@".\Resources/bacs1_x#111.txt", @".\Resources/bacs1_x#11.txt");
            File.Delete(@".\Resources/bacs1_x#111.txt");

            timer5.Start();

            timer3.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                endh.name = "Unknown";
            }
            else
            {
                endh.name = textBox1.Text;
            }

            int summ = endh.pts + endh.bon;
            endh.highsc.Add(Tuple.Create(endh.name, summ));

            endh.DecryptFile(@".\Resources/bacs1_x#111.txt", @".\Resources/bacs1_x#11.txt");
            File.Delete(@".\Resources/bacs1_x#111.txt");

       
            timer5.Start();
            timer1.Start();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.nobutshiny;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.yesshiny;
        }

        private void Endform_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.yesshady;
            pictureBox2.Image = Properties.Resources.nobutshady;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            StreamWriter strw = new StreamWriter(@".\Resources/bacs1_x#11.txt", true);
                strw.WriteLine(endh.highsc[0].Item1 + ' ' + endh.highsc[0].Item2);
            //strw.WriteLine("nenad 20");

            strw.Close();
            timer5.Stop();
        }
    }
}
