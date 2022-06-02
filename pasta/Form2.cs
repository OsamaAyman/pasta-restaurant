using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace pasta
{
    public partial class Form2 : Form
    {
        //constructor
        public Form2(string type)
        {
            InitializeComponent();
            if(type=="menu")
            {
                menu_control menu = new menu_control();
                front_panal.Controls.Clear();
                front_panal.Controls.Add(menu);
            }
            else if (type == "order")
            {
                order_control order = new order_control();
                front_panal.Controls.Clear();
                front_panal.Controls.Add(order);
            }
            else if (type == "chart")
            {
               chart_control chart = new chart_control();
                front_panal.Controls.Clear();
                front_panal.Controls.Add(chart);
            }
            else if (type == "bestBoy")
            {
                bestBoy_control bestBoy = new bestBoy_control();
                front_panal.Controls.Clear();
                front_panal.Controls.Add(bestBoy);
            }
            recommend_food();
        }

        //function select the item with max number of order (bonus)
        public void recommend_food()
        {
            int id = 0;
            string name = "";
            XmlDocument doc = new XmlDocument();
            doc.Load("Menu.xml");
            XmlNodeList list = doc.GetElementsByTagName("no_of_order");
            XmlNodeList listname = doc.GetElementsByTagName("name");

            int largest = int.Parse(list[0].InnerText);
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (int.Parse(list[i].InnerText) > largest)
                {
                    largest = int.Parse(list[i].InnerText);
                    name = listname[i].InnerText;
                    index = i;
                }
            }

            id = index + 1;
            recom_name.Text = name;
            recom_pic.ImageLocation = string.Format(@"items picture\{0}.jpg", id);
        }

        /*-------------------------------events----------------------------------*/
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
