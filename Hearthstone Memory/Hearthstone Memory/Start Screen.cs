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
using System.Reflection;


//IF THERE IS ANY ERROR, DELETE THE RELEASE/DEBUG AND TRY AGAIN !
//IF THERE IS ANY ERROR, DELETE THE RELEASE/DEBUG AND TRY AGAIN !
//IF THERE IS ANY ERROR, DELETE THE RELEASE/DEBUG AND TRY AGAIN !
//IF THERE IS ANY ERROR, DELETE THE RELEASE/DEBUG AND TRY AGAIN !
//IF THERE IS ANY ERROR, DELETE THE RELEASE/DEBUG AND TRY AGAIN !

namespace Hearthstone_Memory
{
    public partial class Start_Screen : Form
    {
        Hig h = new Hig();
        public Start_Screen()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Gwind();
            myForm.Closed += (s, args) => this.Close();
            myForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Gwind();
            myForm.Closed += (s, args) => this.Close();
            myForm.Show();
        }



        private void Start_Screen_Load(object sender, EventArgs e)
        {

            //@"../../Resources/citiesenc.txt"
            //var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "Hearthstone_Memory.Properties.Text.txt";

            //using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            Directory.CreateDirectory(@".\Resources");
            if(! File.Exists(@".\Resources/bacs1_x#111.txt"))
                {
                File.Copy(@"../../Resources/bacs1_x#111.txt", @".\Resources/bacs1_x#111.txt");
            }


            h.DecryptFile(@".\Resources/bacs1_x#111.txt", @".\Resources/bacs1_x#11.txt");
            File.Delete(@".\Resources/bacs1_x#111.txt");

            StreamReader read = new StreamReader(@".\Resources/bacs1_x#11.txt");
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    String[] temp = line.Split(' ');
                    h.highsc = h.highsc.OrderBy(x => x.Item2).ToList();
                    h.highsc.Add(Tuple.Create(temp[0], Convert.ToInt32(temp[1])));
                }
            }
            h.highsc = h.highsc.OrderByDescending(x => x.Item2).ToList();
            for (int i = 0; i < h.highsc.Count; i++)
            {
                int x = i + 1;
                ListViewItem item = new ListViewItem(x.ToString());
                item.SubItems.Add(h.highsc[i].Item1);
                item.SubItems.Add(h.highsc[i].Item2.ToString());
                listView1.Items.Add(item);


            }
            timer1.Start();
        }

        private void Start_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //h.EncryptFile(@".\Resources/bacs1_x#11.txt", @".\Resources/bacs1_x#111.txt");
            //File.Delete(@".\Resources/bacs1_x#11.txt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            h.EncryptFile(@".\Resources/bacs1_x#11.txt", @".\Resources/bacs1_x#111.txt");
            File.Delete(@".\Resources/bacs1_x#11.txt");
            timer1.Stop();
        }


      

        private void Start_Screen_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.latest11;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.latest1;
        }
    }
}
