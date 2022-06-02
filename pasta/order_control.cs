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
    
    public partial class order_control : UserControl
    {
        /*----------------------data members---------------------*/
        double money = 0;
        double discount = 0;
        List<delivery_boy> availabe_boys = new List<delivery_boy>();
        List<Customer> customerList = new List<Customer>();
        List<item> items=new List<item>();
        List<menu_class> menu_list = new List<menu_class>();
        List<item> list_will_be_removed = new List<item>();
        List<item> listofq = new List<item>();
        List<delivery_boy> recievedlist = new List<delivery_boy>();
        List<menu_class> orderdList = new List<menu_class>();
        Dictionary<string, double> priceInMenu = new Dictionary<string, double>();
        delivery_boy boy_of_order;
        /*----------------------/data members---------------------*/

        //constructor
        public order_control()
        {

        
            InitializeComponent();
            if (File.Exists("Customer.xml"))
            {

                XmlSerializer xs = new XmlSerializer(customerList.GetType());
                FileStream fs = new FileStream("Customer.xml", FileMode.Open);
                customerList = (List<Customer>)xs.Deserialize(fs);
                fs.Close();
            }
             fn_menuList();
            bill_panel.Visible = false;
            items_panel.Visible = false;
            information_panel.Visible = true;


        }


        /*--------------------------------functions----------------------------------*/

        //function to to get my menu from file 
        public void fn_menuList()
        {

            XmlSerializer xs = new XmlSerializer(menu_list.GetType());
            FileStream fs = new FileStream("Menu.xml", FileMode.Open);
            menu_list = (List<menu_class>)xs.Deserialize(fs);
            fs.Close();
            /*------------------------------------------------*/
            //fill list of item name and quantity 
            list_will_be_removed.Clear();
            for (int i = 0; i < menu_list.Count; i++)
            {
                item j = new item(menu_list[i].name, menu_list[i].quantity);
                list_will_be_removed.Add(j);
            }
            /*------------------------------------------*/

            //fill dictionary of item name and price
            priceInMenu.Clear();
            for (int i = 0; i < menu_list.Count; i++)
            {

                priceInMenu.Add(menu_list[i].name, menu_list[i].price);
            }
            /*------------------------------------------*/

            //fill combo box with menu 
            nameList.Items.Clear();
            for (int i = 0; i < menu_list.Count; i++)
            {
                nameList.Items.Add(menu_list[i].name);
            }
            /*------------------------------------------------*/
        }

        //every item added will add in datagridview in order and datagridview in items panel
        public void fill_gridview(string name)
        {
            double total = int.Parse(quantity_txtbox.Text) * priceInMenu[name];

            gv_in_items.Rows.Add(quantity_txtbox.Text, name, priceInMenu[name],total.ToString());
            gv_in_bill.Rows.Add(quantity_txtbox.Text, name, priceInMenu[name], total.ToString());

        }

        //fill list (availabe_boys) with the boys available in this area 
        public void choose_delivery_boy()
        {
            FileStream fs = new FileStream("deliveryboy.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(recievedlist.GetType());
            recievedlist = (List<delivery_boy>)xs.Deserialize(fs);
            fs.Close();
            for (int i = 0; i < recievedlist.Count; i++)
            {
                if (area_comboBox.Text == recievedlist[i].area)
                {
                  availabe_boys.Add(recievedlist[i]);
                }
            }
            int convert = convert_time(orderTime.Text);
            List<delivery_boy> deletedboy = new List<delivery_boy>();
            for (int i = 0; i < availabe_boys.Count; i++)
            {
                for (int j = 0; j < availabe_boys[i].list_date.Count; j++)
                {
                    if (orderDate.Text == availabe_boys[i].list_date[j].date)
                    {
                        
                        if (convert == convert_time(availabe_boys[i].list_date[j].time))
                        {
                           
                            deletedboy.Add(availabe_boys[i]);
                        }
                    }
                }
            }
            for (int i = 0; i < deletedboy.Count; i++)
            {
                availabe_boys.Remove(deletedboy[i]);
            }            
        }

        // if the customer is premium awarded with 10% discount
        public void calculate_discount(Customer customer, double money)
        {
            
            //get max number of order by customer from customerList and then calculate 80 % 
            //then get mine number of order that Deserves discount 
            //if customer Deserves discount make a 10% discount on his money
            Customer max = customerList[0];
           for(int i=0;i< customerList.Count;i++)
            {
                if(customerList[i].numOfOrders > max.numOfOrders)
                    max = customerList[i];
                
            }
            int minimumOrder = ((max.numOfOrders * 80) / 100);
            if (customer.numOfOrders >= minimumOrder)
                discount =((money * 10) / 100);

            
        }
      
        //convert time from 00:00 to 00
        public int  convert_time(string time)
        {
            string []arr;
            arr=  time.Split(':');
            return int.Parse(arr[0]);
        }


        //increase number of order for each item orderd
        public void best_food(string food)
        {
            List<menu_class> menu = new List<menu_class>();
            FileStream fs = new FileStream("Menu.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(menu.GetType());
            menu = (List<menu_class>)xs.Deserialize(fs);
            for (int i = 0; i < menu.Count; i++)
            {
                if (menu[i].name == food)
                {
                    menu[i].no_of_order++;
                    break;
                }
            }
            fs.Close();
            FileStream fs1 = new FileStream("Menu.xml", FileMode.Truncate);
            fs1.Close();
            FileStream fs2 = new FileStream("Menu.xml", FileMode.Open);
            XmlSerializer xs1 = new XmlSerializer(menu.GetType());
            xs1.Serialize(fs2, menu);
            fs2.Close();

        }


        //make balance with available dilvery boy in specific area (bonus)
        public void balance(string area)
        {
           int a = 10000000;
            int index=0;
            if (availabe_boys.Count == 0)
            {
                bill_panel.Visible = false;
                items_panel.Visible = false;
            MessageBox.Show("No delivery boys available in this time");
                    Form1 f1 = new Form1();
                
                Form2 f2 = (Form2)this.Parent.Parent;
                f2.Hide();
                f1.ShowDialog();
                f2.Close();
                
                return;
            }
            for (int i = 0; i < availabe_boys.Count; i++)
            {
                if (availabe_boys[i].no_of_orders < a)
                {
                    a = availabe_boys[i].no_of_orders;
                    index = i;
                }
            }
            
            availabe_boys[index].no_of_orders++;
            date_time td = new date_time(orderDate.Text,orderTime.Text);
            availabe_boys[index].list_date.Add(td);
           boy_of_order = availabe_boys[index];
            int id = boy_of_order.id;
            FileStream fs1 = new FileStream("deliveryboy.xml", FileMode.Truncate);
            fs1.Close();
            ///////////////////////////////////////////////////////
            for(int i=0;i<recievedlist.Count;i++)
            {
                if (id == recievedlist[i].id)
                {
                    recievedlist.Remove(recievedlist[i]);
                    recievedlist.Add(boy_of_order);
                    break;
                }
            }
            ///////////////////////////////////////////////////////////
            FileStream fs2 = new FileStream("deliveryboy.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(recievedlist.GetType());
            xs.Serialize(fs2, recievedlist);
            fs2.Close();

        }
        

                    /*--------not required functions------------*/

        //if day = day -> get all items with new quantity in list_will_be_removed 
        public void check_day(string day)
        {
            bool ok = false;
            if (!File.Exists("day_Quantity.xml"))
            {
                FileStream fs = new FileStream("day_Quantity.xml", FileMode.Create);
                fn_menuList();
                fs.Close();

            }
            else
            {
                List<class_Day> list = new List<class_Day>();
                FileStream fs = new FileStream("day_Quantity.xml", FileMode.Open);
                XmlSerializer xs = new XmlSerializer(list.GetType());
                if (fs.Length > 0)
                {
                    list = (List<class_Day>)xs.Deserialize(fs);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].day == day)
                        {
                            ok = true;
                            list_will_be_removed.Clear();
                            list_will_be_removed = list[i].items_in_day;
                            nameList.Items.Clear();
                            for (int j = 0; j < list[i].items_in_day.Count; j++)
                            {
                                if (list[i].items_in_day[j].quantity != 0)
                                    nameList.Items.Add(list[i].items_in_day[j].name);
                            }
                            break;
                        }
                    }
                    if (ok == false)
                        fn_menuList();
                }
                else
                    fn_menuList();
                //idList.Items.Clear();
                fs.Close();

            }
        }

        public void the_end()
        {
            bool close = false;
            List<class_Day> list = new List<class_Day>();

            FileStream fs = new FileStream("day_Quantity.xml", FileMode.Open);
            if (fs.Length == 0)
            {

                XmlSerializer xs = new XmlSerializer(list.GetType());
                class_Day removed_day = new class_Day(orderDate.Text, listofq);
                list.Add(removed_day);
                xs.Serialize(fs, list);
                fs.Close();
                close = true;
            }
            else
            {
                if (!close)
                    fs.Close();

                FileStream fs1 = new FileStream("day_Quantity.xml", FileMode.Open);
                XmlSerializer xs = new XmlSerializer(list.GetType());
                list = (List<class_Day>)xs.Deserialize(fs1);
                fs1.Close();
                FileStream fs2 = new FileStream("day_Quantity.xml", FileMode.Truncate);
                fs2.Close();
                FileStream fs3 = new FileStream("day_Quantity.xml", FileMode.Open);
                XmlSerializer xs1 = new XmlSerializer(list.GetType());
               // class_Day removed_day = new class_Day(orderDate.Text, list_will_be_removed);
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].day == orderDate.Text)
                        list.Remove(list[i]);

                }
                class_Day removed_day1 = new class_Day(orderDate.Text, listofq);
                list.Add(removed_day1);
                xs1.Serialize(fs3, list);
                fs3.Close();
            }

        }


        /*------------------------------/functions------------------------------------*/


        /*------------------------------events----------------------------------------*/

        //confirm information from user
        private void confirm_Click(object sender, EventArgs e)
        {
        
            bool ok = true;
            if(phone_textBox.Text.Count()==0)
            {
                phone_error.Text = "*Enter your phone";
                ok = false;
            }
            else
                phone_error.Text = "";
            /*-------------------------------------------------------*/
            if (address_textBox.Text.Count() == 0)
            {
                address_error.Text = "*Enter your address";
                ok = false;
            }
            else
                address_error.Text = "";
            /*-------------------------------------------------------*/
            if (area_comboBox.Text.Count() == 0)
            {
                area_error.Text = "*Select Area";
                ok = false;
            }
            else
                area_error.Text = "";
            /*-------------------------------------------------------*/
            if (orderTime.Text.Count() == 0)
            {
                time_error.Text = "*Select Time";
                ok = false;
            }
            else
                time_error.Text = "";
            /*-------------------------------------------------------*/
            if(orderDate.Value<DateTime.Today)
            {
                date_error.Text = "*Date invalid";
                ok = false;
            }
            else
                date_error.Text = "";
            /*-------------------------------------------------------*/
            if (ok)
            {
                bill_panel.Visible = false;
                information_panel.Visible = false;
                items_panel.Visible = true;
                fn_menuList();
                check_day(orderDate.Text);
                listofq = list_will_be_removed;
                choose_delivery_boy();
                

            }

        }

        //add items in list called items and increase money
        private void addItem_Click(object sender, EventArgs e)
        {

            bool ok = true;
            if (nameList.Text.Count() == 0)
            {
                ID_error.Text = "*Select Name";
                ok = false;
            }
            else
                ID_error.Text = "";
            /*-------------------------------------------------------*/
            if (quantity_txtbox.Text.Count() == 0)
            {
                quantity_error.Text = "*Enter Quantity";
                ok = false;
            }
            else
                quantity_error.Text = "";
            /*-------------------------------------------------------*/
            if (ok)
            {
                item item = new item();
                item.name = nameList.Text;
                item.quantity = int.Parse(quantity_txtbox.Text);
                bool exist = false;
                bool avilable = true;

                //check if quantity for item in this day avilable or not 
                for (int i = 0; i < listofq.Count; i++)
                {
                    if (item.name == listofq[i].name)
                    {
                        if (item.quantity > listofq[i].quantity)
                        {
                            MessageBox.Show("The Quantity isn't available!");
                            avilable = false;
                        }
                        else
                        {
                            //MessageBox.Show(listofq[i].quantity.ToString());
                            listofq[i].quantity = listofq[i].quantity - item.quantity;
                            // MessageBox.Show(listofq[i].quantity.ToString());
                        }
                        break;
                    }
                }
                /*----------------------------------------------------------------*/
                if (avilable)
                {
                    best_food(nameList.Text);
                    order_btn.Visible = true;
                    for (int i = 0; i < items.Count; i++)
                    {
                        if (items[i].name == item.name)
                        {
                            items[i].quantity += item.quantity;
                            exist = true;
                        }
                    }
                    if (!exist)
                        items.Add(item);
                    /////////////////////////////////////////////////
                    money += item.quantity * priceInMenu[item.name];
                    //////////////////////////////////////////////////
                    fill_gridview(item.name);
                }
            }
        }
       
        //last step to make the order 
        private void order_btn_Click(object sender, EventArgs e)
        {
         
            the_end();
           Customer customer = new Customer();
            customer.phone = phone_textBox.Text;
            customer.area = area_comboBox.Text;
            customer.adress = address_textBox.Text;
            customer.orderDate = orderDate.Text;
            customer.orderTime = orderTime.Text;
            customer.money = money;
            customer.orderList = items;
            for (int i = 0; i < customerList.Count; i++)
            {
                if (customerList[i].phone == customer.phone)
                    customer.numOfOrders++;
            }

            customerList.Add(customer);
            XmlSerializer xs = new XmlSerializer(customerList.GetType());
            FileStream fs = new FileStream("Customer.xml", FileMode.OpenOrCreate);
            xs.Serialize(fs, customerList);
            fs.Close();
            balance(area_comboBox.Text);
            calculate_discount(customer, customer.money);

            /*----------------------------------------*/
            items_panel.Visible = false;
            information_panel.Visible = false;
            bill_panel.Visible = true;
            order_date_label.Text = orderDate.Text;
            order_time_label.Text = orderTime.Text;
            DateTime dt = DateTime.Parse(DateTime.Now.ToString());
            receipt_time_label.Text = dt.ToString("HH:mm");
            receipt_date_label.Text = dt.ToString("dd/MM/yyyy");
            subTotal.Text = money.ToString()+" $";
            discount_label.Text = discount.ToString() + " $";
            total.Text = (money - discount).ToString() + " $";
            boyName_label.Text = boy_of_order.name;
            boyPhone_label.Text = boy_of_order.phone;
            /*----------------------------------------*/

        }

        //make textbox don't accept any thing except numbers
        private void numbers(object sender, EventArgs e)
        {
            var se = (TextBox)sender;
            if (!System.Text.RegularExpressions.Regex.IsMatch(se.Text, "^[0-9]*$"))
            {
                se.Text = "";
            }
        }

        //take a screenshot for bill
        private void screenshot_Click(object sender, EventArgs e)
        {
            screenshot.Visible = false;
            Rectangle rect = this.RectangleToScreen(this.ClientRectangle);
            Bitmap bitmap = new Bitmap(this.Parent. Width, this.Parent. Height);
            Graphics gf = Graphics.FromImage(bitmap as Image);
            gf.CopyFromScreen(rect.Location,Point.Empty,this.Size);
            saveFileDialog1.Filter = " (*.jpg)|*.jpg";
            saveFileDialog1.ShowDialog();
            bitmap.Save(saveFileDialog1.FileName.ToString());
            screenshot.Visible = true;
        }

        /*-----------------------------/events------------------------------------*/
    }

}
