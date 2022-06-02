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
    public partial class chart_control : UserControl
    {
        /*-----------------------------data member---------------------*/
        string area, start, end;
        List<Customer> all_orders = new List<Customer>();
        List<Customer> orders_in_area = new List<Customer>();
        List<string> months_repeated = new List<string>();
        Dictionary<string, int> months_in_Interval = new Dictionary<string, int>();
        /*-----------------------------------------------------------*/
        public chart_control()
        {
            InitializeComponent();
            FileStream fs = new FileStream("Customer.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(all_orders.GetType());
            all_orders = (List<Customer>)xs.Deserialize(fs);
            fs.Close();
        }


        //convert long date to only month
        string convert_date_to_month(string date)
        {
            string[] arr;
            string[] arr2;
            arr = date.Split(',');
            arr2 = arr[1].Split(' ');
            return arr2[1];

        }

        //convent month from string to int like January --> 1
        int convert_month_to_int(string month)
        {
            if (month == "January")
                return 1;
            if (month == "Febuary")
                return 2;
            if (month == "March")
                return 3;
            if (month == "April")
                return 4;
            if (month == "May")
                return 5;
            if (month == "June")
                return 6;
            if (month == "July")
                return 7;
            if (month == "August")
                return 8;
            if (month == "September")
                return 9;
            if (month == "Octobor")
                return 10;
            if (month == "November")
                return 11;
            if (month == "December")
                return 12;
            else
                return 0;
        }

        //get all orders in specific area
        void  getAllOrdersInArea()
        {


            for (int i = 0; i < all_orders.Count; i++)
            {
                if (all_orders[i].area == area)         
                    orders_in_area.Add(all_orders[i]);
                  
            }
        }

        //get the specific data i will use in chart
        void get_last_data()
        {

            
            
            for (int i = 0; i < orders_in_area.Count; i++)
            {
                if (convert_month_to_int(convert_date_to_month(orders_in_area[i].orderDate)) >= convert_month_to_int(start)
                    && convert_month_to_int(convert_date_to_month(orders_in_area[i].orderDate)) <= convert_month_to_int(end))
                {
                    months_repeated.Add(convert_date_to_month(orders_in_area[i].orderDate));
                }
            }

            for (int i = 0; i < months_repeated.Count; i++)
            {

                if (months_in_Interval.ContainsKey(months_repeated[i]))
                    months_in_Interval[months_repeated[i]]++;
                else
                    months_in_Interval.Add(months_repeated[i], 1);
            }
        }

        //event to display chart
        private void display_Click(object sender, EventArgs e)
        {
            bool ok=true;
            if(area_combo.Text.Count()==0)
            {
                area_error.Text = "*Please choose area";
                ok = false;
            }
            else
                area_error.Text = "";
            /*-------------------------------------------------------------------*/
            if (start_date.Text.Count() == 0)
            {
                start_error.Text = "*Please choose start date";
                ok = false;
            }
            else
                start_error.Text = "";
            /*-------------------------------------------------------------------*/
            if (end_date.Text.Count() == 0)
            {
                end_error.Text = "*Please choose end date";
                ok = false;
            }
            else
                end_error.Text = "";
            /*-------------------------------------------------------------------*/

            if (ok)
            {
                orders_in_area.Clear();
                months_in_Interval.Clear();
                months_repeated.Clear();
                chart1.Series["Series1"].Points.Clear();
                area = area_combo.Text;
                start = start_date.Text;
                end = end_date.Text;

                getAllOrdersInArea();
                get_last_data();
                foreach(var month in months_in_Interval)
                {
                    chart1.Series["Series1"].Points.AddXY(month.Key, month.Value);

                }
               chart1.Series["Series1"].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Ascending);

            }
        }
    }
}
