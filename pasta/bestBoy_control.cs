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

namespace pasta
{
    public partial class bestBoy_control : UserControl
    {
        public bestBoy_control()
        {
            InitializeComponent();

            int a = -1;
            List<delivery_boy> list = new List<delivery_boy>();
            delivery_boy best = new delivery_boy();
            FileStream fs = new FileStream("deliveryboy.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(list.GetType());
            list = (List<delivery_boy>)xs.Deserialize(fs);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].no_of_orders > a)
                {
                    best = list[i];
                    a = list[i].no_of_orders;
                }
            }

            id.Text = best.id.ToString();
            name.Text = best.name;
            phone.Text = best.phone;
            area.Text = best.area;
            order.Text = best.no_of_orders.ToString();
        }
    }
}
