using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Speech.Synthesis;
using System.Speech;

namespace pasta
{
    public partial class menu_control : UserControl
    {
       
        public menu_control()
        {
             
            
            InitializeComponent();
            
        }

      
     

            List<menu_class> menu_list = new List<menu_class>();
        private void menu_control_Load(object sender, EventArgs e)
        {
            XmlSerializer xs = new XmlSerializer(menu_list.GetType());
            FileStream fs = new FileStream("menu.xml", FileMode.Open);
            menu_list = (List<menu_class>)xs.Deserialize(fs);
            fs.Close();
            menu_gridview.DataSource = menu_list;
           

        }

        private void menu_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = menu_gridview.CurrentRow.Cells[0].Value.ToString();
            item_picture.ImageLocation = string.Format(@"items picture\{0}.jpg", int.Parse(id));

            if (sound_switch.Value == true)
            {
                SpeechSynthesizer voice = new SpeechSynthesizer();
                string name = menu_gridview.CurrentRow.Cells[1].Value.ToString();
                voice.Speak(name);

            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            bool ok = false;
            string Name="";
           double price=0.0;
            for (int i = 0; i < menu_list.Count; i++)
            {
                if (search_txt.Text == menu_list[i].name)
                {
                    price =menu_list[i].price;
                    Name =search_txt.Text;
                    ok = true;
                    break;
                }
            }
            if (ok)
            {
                MessageBox.Show("The Price is: " + price.ToString(), Name);
            }
            else MessageBox.Show("It Doesn't Exists!");
            search_txt.Text = "";
        }
    }
}
