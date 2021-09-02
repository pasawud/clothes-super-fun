
using System;
using System.Collections.Generic;

namespace Gameplay
{
    class Program
    {
        static void Main(string[] args)
        {
            //ข้อมูลนายเจม
            User jame = new User("jame watson", "jame@gmail.com");
            T_shirt shirt1 = new T_shirt("L", "LOki", "red", 500);
            T_shirt shirt2 = new T_shirt("M", "Wanda Vision", "Black", 750);
            T_shirt shirt3 = new T_shirt("S", "Taylor", "Black", 625);
            //ข้อมูลที่อยู่
            Address ad1 = new Address("131/75", "Phutthamonthon Rd","Nakhon Pathom,","10180");
            //out put 
            jame.Cart(ad1);
            jame.lists(shirt1);
            jame.lists(shirt2);
            jame.lists(shirt3);
            //out put 
            ad1.Finaladdress();
            shirt1.sent();
            shirt2.sent();
            shirt3.sent();
            jame.overall();
            Console.ReadLine();
        }
        class T_shirt
        {
            public string size, color, image;
            public float price;     
            public T_shirt(string value_Size,string value_image,string value_color,float value_price)
            {
                size = value_Size;
                color = value_color;
                image = value_image;
                price = value_price;
            }
            public  void sent()
            {
                Console.WriteLine("Shirt size = {0}", this.size);
                Console.WriteLine("Shirt color = {0}", this.color);
                Console.WriteLine("Shirt price = {0}", this.price);
            }
        }
        class User
        {
            public string name;
            public string email;
            private List <T_shirt> OderTShirt;
            public User (string value_name,string value_email)
            {
                name = value_name;
                email = value_email;
                OderTShirt = new List<T_shirt>();
            }
            public void Cart(Address address)
            {
                OderTShirt = new List<T_shirt>();
                Address jameAddress = address;
            }
            public void lists(T_shirt tshirt)
            {
                OderTShirt.Add(tshirt);
            }
            public void overall()
            {
                int all = 1;
                float prize = 0;
                foreach (T_shirt t_Shirt in OderTShirt)
                {
                    prize += t_Shirt.price; 
                    all++;

                    if (all == OderTShirt.Capacity)
                    {
                        Console.WriteLine("jame need to pay {0} ", prize);
                    }
                }
            }
        }
        class Address
        {
            public string home, street, city, zip;
            public Address (string value_home, string value_street,string value_city, string value_zip)
            {
                home = value_home;
                street = value_street;
                city = value_city;
                zip = value_zip;
            }
            public void Finaladdress()
            {
                Console.WriteLine("This is your address : {0} {1} {2}",this.home, this.street,this.city);
                Console.WriteLine("This is your zip code : {0}", this.zip);
            }
        }
    }
}
