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
using System.Xml.Serialization;

namespace pasta
{
    public partial class Form1 : Form
    {
        int panelWidth;
        bool Hidden;
        int imageNum = 1;
        bool aboutEnable;
        public Form1()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = true;
            PanelSlide.Width = 0;
            aboutEnable = false;
            aboutPanel.Location = new Point(aboutPanel.Location.X, 450);
          
        }
        private void loadNextImage()
        {
            if (imageNum == 10)
                imageNum = 1;
            adsPictureBox.ImageLocation = string.Format(@"images\{0}.jpg", imageNum);
            imageNum++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                PanelSlide.Width = PanelSlide.Width + 10;
                if (PanelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                   // this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 10;
                if (PanelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                  //  this.Refresh();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
          WindowState=FormWindowState.Minimized;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/402128866881166/?ref=bookmarks");
        }

        private void feedback_Click(object sender, EventArgs e)
        {
          string feedback= Microsoft.VisualBasic.Interaction.InputBox("We hope that the service has won your admiration :D", "Feedback", "Your Feedback");
            if(feedback!="")
            {
                FileStream fs = new FileStream("feedback.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(feedback);
                sw.Close();
                fs.Close();
                MessageBox.Show("Thank you for your feedback");
            }
        }

        private void phone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("our phone number is 01xxxxxxxxxx","phone number");
        }

        private void aboutUs_Click(object sender, EventArgs e)
        {
            if (aboutEnable)
                aboutEnable = false;
            else
                aboutEnable = true;

           // if (!(paneltest.Location.Y <= topPanel.Location.Y))
           if(aboutEnable)
                timer3.Start();
            else
            {
               
                aboutPanel.Location = new Point(aboutPanel.Location.X, 450);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            aboutPanel.Location = new Point(aboutPanel.Location.X, aboutPanel.Location.Y - 5);
            if (aboutPanel.Location.Y == topPanel.Location.Y)
                timer3.Stop();
            
        }

        private void menu_Click(object sender, EventArgs e)
        {
           
            Form2 form = new Form2("menu");
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void order_Click(object sender, EventArgs e)
        {
           
            Form2 form = new Form2("order");
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void chart_Click(object sender, EventArgs e)
        {
          
            Form2 form = new Form2("chart");
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void delivery_boy_btn_Click(object sender, EventArgs e)
        {

            Form2 form = new Form2("bestBoy");
            this.Hide();
            form.ShowDialog();
            this.Close();


        }
    }
}
