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
    public partial class Gwind : Form
    {
        
        
        
        double timm = 1;
        Random loc = new Random();
        public Hig h = new Hig();
        PictureBox open1;
        PictureBox open2;
        PictureBox temp1;
        PictureBox temp2;
        SoundPlayer player = new SoundPlayer(Properties.Resources.tricks_of_the_trade);
        SoundPlayer player1 = new SoundPlayer(Properties.Resources.fail_buzzer_04);
        SoundPlayer player2 = new SoundPlayer(Properties.Resources.small_bell_ring_01a);

        int done = 0;
        public Gwind()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gwind_Load(object sender, EventArgs e)
        {
            BringToFront();
            h.bon = 50;
            h.pts = 0;
            player.Play();
           
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Enabled = false;
                h.pos.Add(picture.Location);
            }
            foreach (PictureBox picture in panel1.Controls)
            {
                int i = loc.Next(h.pos.Count);
                Point z = h.pos[i];
                picture.Location = z;
                h.pos.Remove(z);
            }
            timer1.Start();
            timer7.Start();
            
            c1.Image = Properties.Resources.card1;
            sc1.Image = Properties.Resources.card1;
            c2.Image = Properties.Resources.card2;
            sc2.Image = Properties.Resources.card2;
            c3.Image = Properties.Resources.card3;
            sc3.Image = Properties.Resources.card3;
            c4.Image = Properties.Resources.card4;
            sc4.Image = Properties.Resources.card4;
            c5.Image = Properties.Resources.card5;
            sc5.Image = Properties.Resources.card5;
            c6.Image = Properties.Resources.card6;
            sc6.Image = Properties.Resources.card6;
            c7.Image = Properties.Resources.card7;
            sc7.Image = Properties.Resources.card7;
            c8.Image = Properties.Resources.card8;
            sc8.Image = Properties.Resources.card8;
            c9.Image = Properties.Resources.card9;
            sc9.Image = Properties.Resources.card9;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tx = Convert.ToInt32(cd.Text);
            tx = tx - 1;
            cd.Text = tx.ToString();
            

            if (tx == 0)
            {
                timer1.Stop();
                timer5.Start();
                timer6.Start();
                foreach (PictureBox picture in panel1.Controls)
                {   
                    picture.Enabled = true;
                    picture.Cursor = Cursors.Hand;
                    
                    picture.Image = Properties.Resources.cover111;
                }
            }
        }
        private void c1_Click(object sender, EventArgs e)
        {
            
           
            if (open1 == null )
            {
                c1.Image = Properties.Resources.card1;
                open1 = c1;
                c1.Enabled = false;
            }
            else if (open1 != null && open2 == null )
            {
                c1.Image = Properties.Resources.card1;
                open2 = c1;
                if (open1.Tag == open2.Tag)
                {
                    success();
                   
                    c1.Enabled = false;
                    sc1.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {

                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                    
                    
                    fail();
                    c1.Enabled = false;
                    timer2.Start();
                }
            }  

        }

        private void sc1_Click(object sender, EventArgs e)
        {
           
            
            if (open1 == null)
            {
                sc1.Image = Properties.Resources.card1;
                open1 = sc1;
                sc1.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                sc1.Image = Properties.Resources.card1;
                open2 = sc1;
                if (open1.Tag == open2.Tag)
                {
                    success();
                    
                    c1.Enabled = false;
                    sc1.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {

                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                   
                    
                    fail();
                    sc1.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            
            
            if (open1 == null)
            {
                c2.Image = Properties.Resources.card2;
                open1 = c2;
                c2.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                c2.Image = Properties.Resources.card2;
                open2 = c2;
                if (open1.Tag == open2.Tag)
                {
                    success();
                    
                    sc2.Enabled = false;
                    c2.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                  
                    
                    fail();
                    c2.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void sc2_Click(object sender, EventArgs e)
        {
            
           
            if (open1 == null)
            {
                sc2.Image = Properties.Resources.card2;
                open1 = sc2;
                sc2.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                sc2.Image = Properties.Resources.card2;
                open2 = sc2;
                if (open1.Tag == open2.Tag)
                {
                    success();
                    
                    c2.Enabled = false;
                    sc2.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                   
                  
                    fail();
                    sc2.Enabled = false;
                    timer2.Start();
                }
            }

        }

        private void c3_Click(object sender, EventArgs e)
        {
            
           
            if (open1 == null)
            {
                c3.Image = Properties.Resources.card3;
                open1 = c3;
                c3.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                c3.Image = Properties.Resources.card3;
                open2 = c3;
                if (open1.Tag == open2.Tag)
                {
                    success();
                    
                    sc3.Enabled = false;
                    c3.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                   
                    
                    fail();
                    c3.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void sc3_Click(object sender, EventArgs e)
        {
          
            
            if (open1 == null)
            {
                sc3.Image = Properties.Resources.card3;
                open1 = sc3;
                sc3.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                sc3.Image = Properties.Resources.card3;
                open2 = sc3;
                if (open1.Tag == open2.Tag)
                {
                    success();
                   
                    c3.Enabled = false;
                    sc3.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                   
                    
                    fail();
                    sc3.Enabled = false;
                    timer2.Start();
                }
            }
        }
        private void c4_Click(object sender, EventArgs e)
        {
            
            
            if (open1 == null)
            {
                c4.Image = Properties.Resources.card4;
                open1 = c4;
                c4.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                c4.Image = Properties.Resources.card4;
                open2 = c4;
                if (open1.Tag == open2.Tag)
                {
                    success();
                    
                    sc4.Enabled = false;
                    c4.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                    
                    
                    fail();
                    c4.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void sc4_Click(object sender, EventArgs e)
        {
            
            
            if (open1 == null)
            {
                sc4.Image = Properties.Resources.card4;
                open1 = sc4;
                sc4.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                sc4.Image = Properties.Resources.card4;
                open2 = sc4;
                if (open1.Tag == open2.Tag)
                {
                    success();
                   
                    c4.Enabled = false;
                    sc4.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                   
                   
                    fail();
                    sc4.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void c5_Click(object sender, EventArgs e)
        {
         
            
            if (open1 == null)
            {
                c5.Image = Properties.Resources.card5;
                open1 = c5;
                c5.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                c5.Image = Properties.Resources.card5;
                open2 = c5;
                if (open1.Tag == open2.Tag)
                {
                    success();
                   
                    sc5.Enabled = false;
                    c5.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                   
                    
                    fail();
                    c5.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void sc5_Click(object sender, EventArgs e)
        {
            
            
            if (open1 == null)
            {
                sc5.Image = Properties.Resources.card5;
                open1 = sc5;
                sc5.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                sc5.Image = Properties.Resources.card5;
                open2 = sc5;
                if (open1.Tag == open2.Tag)
                {
                    success();
                    
                    c5.Enabled = false;
                    sc5.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                    
                    
                    fail();
                    sc5.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void c6_Click(object sender, EventArgs e)
        {
            
            
            if (open1 == null)
            {
                c6.Image = Properties.Resources.card6;
                open1 = c6;
                c6.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                c6.Image = Properties.Resources.card6;
                open2 = c6;
                if (open1.Tag == open2.Tag)
                {
                    success();
                    
                    sc6.Enabled = false;
                    c6.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                    
                  
                    fail();
                    c6.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void sc6_Click(object sender, EventArgs e)
        {
            
            
            if (open1 == null)
            {
                sc6.Image = Properties.Resources.card6;
                open1 = sc6;
                sc6.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                sc6.Image = Properties.Resources.card6;
                open2 = sc6;
                if (open1.Tag == open2.Tag)
                {
                    success();
                    
                    c6.Enabled = false;
                    sc6.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                    
                    
                    fail();
                    sc6.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void c7_Click(object sender, EventArgs e)
        {
           
            
            if (open1 == null)
            {
                c7.Image = Properties.Resources.card7;
                open1 = c7;
                c7.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                c7.Image = Properties.Resources.card7;
                open2 = c7;
                if (open1.Tag == open2.Tag)
                {
                    success();
                   
                    sc7.Enabled = false;
                    c7.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                    
                   
                    fail();
                    c7.Enabled = false;
                    timer2.Start();
                }
            }
        }
        private void sc7_Click(object sender, EventArgs e)
        {
           
            
            if (open1 == null)
            {
                sc7.Image = Properties.Resources.card7;
                open1 = sc7;
                sc7.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                sc7.Image = Properties.Resources.card7;
                open2 = sc7;
                if (open1.Tag == open2.Tag)
                {
                    success();
                   
                    c7.Enabled = false;
                    sc7.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                    
                    
                    fail();
                    sc7.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void c8_Click(object sender, EventArgs e)
        {
          
            
            if (open1 == null)
            {
                c8.Image = Properties.Resources.card8;
                open1 = c8;
                c8.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                c8.Image = Properties.Resources.card8;
                open2 = c8;
                if (open1.Tag == open2.Tag)
                {
                    success();
                  
                    sc8.Enabled = false;
                    c8.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                    
                    fail();
                    c8.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void sc8_Click(object sender, EventArgs e)
        {
            
            
            if (open1 == null)
            {
                sc8.Image = Properties.Resources.card8;
                open1 = sc8;
                sc8.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                sc8.Image = Properties.Resources.card8;
                open2 = sc8;
                if (open1.Tag == open2.Tag)
                {
                    success();
                   
                    c8.Enabled = false;
                    sc8.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                   
                    fail();
                    sc8.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void c9_Click(object sender, EventArgs e)
        {
            
            
            if (open1 == null)
            {
                c9.Image = Properties.Resources.card9;
                open1 = c9;
                c9.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                c9.Image = Properties.Resources.card9;
                open2 = c9;
                if (open1.Tag == open2.Tag)
                {
                    success();
                   
                    sc9.Enabled = false;
                    c9.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                    
                    fail();
                    c9.Enabled = false;
                    timer2.Start();
                }
            }
        }

        private void sc9_Click(object sender, EventArgs e)
        {
            
            
            if (open1 == null)
            {
                sc9.Image = Properties.Resources.card9;
                open1 = sc9;
                sc9.Enabled = false;
            }
            else if (open1 != null && open2 == null)
            {
                sc9.Image = Properties.Resources.card9;
                open2 = sc9;
                if (open1.Tag == open2.Tag)
                {
                    success();
                    
                    c9.Enabled = false;
                    sc9.Enabled = false;
                    h.pts = h.pts + 10;
                    brp.Text = h.pts.ToString();
                    open1 = null;
                    open2 = null;
                    done = done + 2;
                    if (done >= 18)
                    {
                        finish();
                    }
                }
                else if (open1.Tag != open2.Tag)
                {
                    fail();
                    sc9.Enabled = false;
                    timer2.Start();

                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            open1.Enabled = true;
            open2.Enabled = true;
            open1.Image = Properties.Resources.cover111;
            open2.Image = Properties.Resources.cover111;
            h.pts = h.pts - 2;
            brp.Text = h.pts.ToString();
            temp1 = null;
            temp2 = null;
            open1 = null;
            open2 = null;
            timer2.Stop();


        }
        private void finish()
        {
            timer5.Stop();
            cd.ForeColor = System.Drawing.Color.White;
            int summ = h.bon + h.pts;
            cd.Text = summ.ToString();
            label2.ForeColor = System.Drawing.Color.White;
            label2.Text = "Total Points:";
            cd.Visible = true;
            label2.Visible = true;
        
            Endform kraj = new Endform();
            kraj.endh = h;
            kraj.Show();

        }
      
        private void fail()
        {
            player.Stop();

            player1.Play();
            timer3.Start();

        }
        private void success()
        {
            player.Stop();          
            
            player2.Play();
            timer4.Start();


        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            
            player.Play();
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            player.Play();
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            h.bon = Convert.ToInt32(tb.Text);
            h.bon = h.bon - 1;
            tb.Text = h.bon.ToString();
            
            if (h.bon == 0)
                timer5.Stop();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            cd.Visible = false;
            label2.Visible = false;
            timer6.Stop();
        }
        public Image FastLoad(string path)
        {
            using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(path)))
                return Image.FromStream(ms);
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            timm = timm - 0.25;
            if (timm == 0.25)
                label4.Text = " ";
            if (timm == 0)
            { label4.Visible = false;
            timer7.Stop();
        }
        }

        private void c1_MouseEnter(object sender, EventArgs e)
        {
            if (c1.Enabled == true)
                c1.Image = Properties.Resources.cover11;
        }

        private void c1_MouseLeave(object sender, EventArgs e)
        {   
            if(c1.Enabled==true)
            c1.Image = Properties.Resources.cover111;
        }

        private void c2_MouseEnter(object sender, EventArgs e)
        {
            if (c2.Enabled == true)
                c2.Image = Properties.Resources.cover11;
        }

        private void c2_MouseLeave(object sender, EventArgs e)
        {
            if (c2.Enabled == true)
                c2.Image = Properties.Resources.cover111;
        }
        private void c3_MouseEnter(object sender, EventArgs e)
        {
            if (c3.Enabled == true)
                c3.Image = Properties.Resources.cover11;
        }

        private void c3_MouseLeave(object sender, EventArgs e)
        {
            if (c3.Enabled == true)
                c3.Image = Properties.Resources.cover111;
        }

        private void c4_MouseEnter(object sender, EventArgs e)
        {
            if (c4.Enabled == true)
                c4.Image = Properties.Resources.cover11;
        }

        private void c4_MouseLeave(object sender, EventArgs e)
        {
            if (c4.Enabled == true)
                c4.Image = Properties.Resources.cover111;
        }
        private void c5_MouseEnter(object sender, EventArgs e)
        {
            if (c5.Enabled == true)
                c5.Image = Properties.Resources.cover11;
        }

        private void c5_MouseLeave(object sender, EventArgs e)
        {
            if (c5.Enabled == true)
                c5.Image = Properties.Resources.cover111;
        }

        private void c6_MouseEnter(object sender, EventArgs e)
        {
            if (c6.Enabled == true)
                c6.Image = Properties.Resources.cover11;
        }

        private void c6_MouseLeave(object sender, EventArgs e)
        {
            if (c6.Enabled == true)
                c6.Image = Properties.Resources.cover111;
        }
        private void c7_MouseEnter(object sender, EventArgs e)
        {
            if (c7.Enabled == true)
                c7.Image = Properties.Resources.cover11;
        }

        private void c7_MouseLeave(object sender, EventArgs e)
        {
            if (c7.Enabled == true)
                c7.Image = Properties.Resources.cover111;
        }

        private void c8_MouseEnter(object sender, EventArgs e)
        {
            if (c8.Enabled == true)
                c8.Image = Properties.Resources.cover11;
        }

        private void c8_MouseLeave(object sender, EventArgs e)
        {
            if (c8.Enabled == true)
                c8.Image = Properties.Resources.cover111;
        }
        private void c9_MouseEnter(object sender, EventArgs e)
        {
            if (c9.Enabled == true)
                c9.Image = Properties.Resources.cover11;
        }

        private void c9_MouseLeave(object sender, EventArgs e)
        {
            if (c9.Enabled == true)
                c9.Image = Properties.Resources.cover111;
        }

        private void sc1_MouseEnter(object sender, EventArgs e)
        {
            if (sc1.Enabled == true)
                sc1.Image = Properties.Resources.cover11;
        }

        private void sc1_MouseLeave(object sender, EventArgs e)
        {
            if (sc1.Enabled == true)
                sc1.Image = Properties.Resources.cover111;
        }
        private void sc2_MouseEnter(object sender, EventArgs e)
        {
            if (sc2.Enabled == true)
                sc2.Image = Properties.Resources.cover11;
        }

        private void sc2_MouseLeave(object sender, EventArgs e)
        {
            if (sc2.Enabled == true)
                sc2.Image = Properties.Resources.cover111;
        }
        private void sc3_MouseEnter(object sender, EventArgs e)
        {
            if (sc3.Enabled == true)
                sc3.Image = Properties.Resources.cover11;
        }

        private void sc3_MouseLeave(object sender, EventArgs e)
        {
            if (sc3.Enabled == true)
                sc3.Image = Properties.Resources.cover111;
        }
        private void sc4_MouseEnter(object sender, EventArgs e)
        {
            if (sc4.Enabled == true)
                sc4.Image = Properties.Resources.cover11;
        }

        private void sc4_MouseLeave(object sender, EventArgs e)
        {
            if (sc4.Enabled == true)
                sc4.Image = Properties.Resources.cover111;
        }
        private void sc5_MouseEnter(object sender, EventArgs e)
        {
            if (sc5.Enabled == true)
                sc5.Image = Properties.Resources.cover11;
        }

        private void sc5_MouseLeave(object sender, EventArgs e)
        {
            if (sc5.Enabled == true)
                sc5.Image = Properties.Resources.cover111;
        }
        private void sc6_MouseEnter(object sender, EventArgs e)
        {
            if (sc6.Enabled == true)
                sc6.Image = Properties.Resources.cover11;
        }

        private void sc6_MouseLeave(object sender, EventArgs e)
        {
            if (sc6.Enabled == true)
                sc6.Image = Properties.Resources.cover111;
        }
        private void sc7_MouseEnter(object sender, EventArgs e)
        {
            if (sc7.Enabled == true)
                sc7.Image = Properties.Resources.cover11;
        }

        private void sc7_MouseLeave(object sender, EventArgs e)
        {
            if (sc7.Enabled == true)
                sc7.Image = Properties.Resources.cover111;
        }
        private void sc8_MouseEnter(object sender, EventArgs e)
        {
            if (sc8.Enabled == true)
                sc8.Image = Properties.Resources.cover11;
        }

        private void sc8_MouseLeave(object sender, EventArgs e)
        {
            if (sc8.Enabled == true)
                sc8.Image = Properties.Resources.cover111;
        }
        private void sc9_MouseEnter(object sender, EventArgs e)
        {
            if (sc9.Enabled == true)
                sc9.Image = Properties.Resources.cover11;
        }

        private void sc9_MouseLeave(object sender, EventArgs e)
        {
            if (sc9.Enabled == true)
                sc9.Image = Properties.Resources.cover111;
        }

        private void sc1_MouseLeave_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
