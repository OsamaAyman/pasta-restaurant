using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace pasta
{
    public class date_time
    {
        public string date;
        public string time;
        public date_time(){}
        public date_time(string day, string time)
        {
            date = day;
            this.time = time;
        }
    }
    public class item
    {
        public string name;
        public int quantity;
        public item(string n, int q)
        {
            name = n;
            quantity = q;
        }
        public item() { }
    }
   
    [Serializable]
    public class Customer
    {
        public string phone;
        public string adress;
        public string area;
        public string orderDate;
        public string orderTime;
        public int numOfOrders = 1;
        public double money = 0;
        public List<item> orderList;

        public Customer()
        {
            orderList = new List<item>();
        }



    }
    public class menu_class
    {
        public string id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int no_of_order;
        public int quantity;
    }

   
    public class delivery_boy
    {
        public int id;
        public string name;
        public string phone;
        public string area;
        public int no_of_orders;
        public List<date_time>list_date;
        public delivery_boy(int id, string name, string phone, string area,List<date_time>l)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.area = area;
            list_date = l;
        }
        public delivery_boy() {list_date = new List<date_time>();}

    }
    public class delivery_file
    {
        public string area;
        public string code;
        public List<int> id_of_boys;
        public delivery_file()
        {
            id_of_boys = new List<int>();

        }
        public delivery_file(string code,string area, List<int> id_of_boys)
        {
            this.code = code;
            this.area = area;
            this.id_of_boys = id_of_boys;
        }
    }

    public class class_Day
    {
        public string day;
        public List<item> items_in_day = new List<item>();
        public class_Day(string d, List<item> i)
        {
            day = d;
            items_in_day = i;
        }
        public class_Day() { }

    }
}

