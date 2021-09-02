using System;
using System.Collections.Generic;

namespace HW1_054
{
    class Program
    {
        static void Main(string[] args)
        {
            User Jame = new User("Jame Watson", "jame@gmail.com");
            Address newAddress = new Address("131/75 Phutthamonthon Rd.", "Nakhon Pathom", "10180");
            T_Shirt redShirt = new T_Shirt("L", "Red", 500.0f, "q(>w<)q");
            T_Shirt blackShirt = new T_Shirt("M", "Black", 750.0f, "T-T");
            T_Shirt purpleShirt = new T_Shirt("S", "Purple", 625.0f, "OwO");

            ShoppingCart JameOrder = new ShoppingCart();
            JameOrder.addOrder(redShirt);
            JameOrder.addOrder(blackShirt);
            JameOrder.addOrder(purpleShirt);
            JameOrder.addAddress(newAddress);

            Jame.NameEmail(Jame);
            JameOrder.printOrder();
            JameOrder.printAddress();
            JameOrder.Payment();

        }

    }

    class T_Shirt
    {
        public string size;
        public string color;
        public float price;
        public string image;
        public T_Shirt(string valueSize, string valueColor, float valuePrice, string valueImage)
        {
            size = valueSize;
            color = valueColor;
            price = valuePrice;
            image = valueImage;
        }
    }

    class User
    {
        public string name;
        public string email;
        public User(string User_name, string User_email)
        {
            name = User_name;
            email = User_email;
        }
        public void NameEmail(User Customer)
        {
            Console.WriteLine(Customer.name);
            Console.WriteLine(Customer.email);
        }

    }

    class Address
    {
        public string street;
        public string city;
        public string zipCode;

        public Address(string valueStreet, string valueCity, string valueuZipCode)
        {
            street = valueStreet;
            city = valueCity;
            zipCode = valueuZipCode;
        }

    }

    class ShoppingCart
    {

        public float Total_cost;
        public List<T_Shirt> orderTShirt;
        public List<Address> userAddress;

        public ShoppingCart()
        {
            orderTShirt = new List<T_Shirt>();
            userAddress = new List<Address>();
        }

        public void addOrder(T_Shirt Order)
        {
            orderTShirt.Add(Order);
        }

        public void addAddress(Address userHome)
        {
            userAddress.Add(userHome);
        }

        public void printOrder()
        {
            foreach (T_Shirt order in orderTShirt)
            {
                Console.Write("{0} {1} {2} {3}, ", order.size, order.color, order.price, order.image);
            }
            Console.WriteLine();
        }

        public void Payment()
        {
            Total_cost = 0;
            foreach (T_Shirt order in orderTShirt)
            {
                Total_cost += order.price;
            }
            Console.WriteLine("Total cost: {0} Baht", Total_cost);
        }

        public void printAddress()
        {
            foreach (Address location in userAddress)
            {
                Console.WriteLine("{0}, {1}, {2}", location.street, location.city, location.zipCode);
            }
        }
    }

}
