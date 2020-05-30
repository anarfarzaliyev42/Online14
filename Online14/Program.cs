using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Net.Cache;
using System.Runtime.InteropServices;

namespace Test
{


    class Program
    {

        static void Main(string[] args)
        {

            //List<User> users = new List<User>()
            //{
            //    new User()
            //    {
            //        Name="Marry",Age=20
            //    },
            //    new User()
            //    {
            //        Name="MJohn",Age=24
            //    },
            //    new User()
            //    {
            //        Name="Jack",Age=8
            //    },
            //    new User()
            //    {
            //        Name="PhilipM",Age=40
            //    },
            //    new User()
            //    {
            //        Name="Lukem",Age=35
            //    }
            //};

            //var newUsers = users.Where(x=> x.Age>20 && x.Name.ToUpper().Contains("M")).ToList();
            //foreach (var item in newUsers)
            //{
            //    Console.WriteLine(item.Name);
            //}

            Dictionary<string, List<Product>> list = new Dictionary<string, List<Product>>();

            list.Add("phone", new List<Product>()
            {
                new Product(){ID=1,Name="Iphone"},
                new Product(){ID=2,Name="Samsung"},
            });

            list.Add("tv", new List<Product>()
            {
                new Product(){ID=3,Name="Lg"},
                new Product(){ID=4,Name="AAA"},
            }
            );

            var tvList = list["tv"];

            foreach (var item in tvList)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }


    }
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    // class User
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
    //class Product
    //{
    //    public string ID { get; set; }
    //    public string Name { get; set; }


    //}
    //class User
    //{
    //    public string UserName { get; set; }
    //    public string Password { get; set; }
    //    public List<Product> Orders { get; set; }
    //    public void ShowMyProducts()
    //    {
    //        foreach (var item in Orders)
    //        {
    //            Console.WriteLine(item.Name );
    //        }
    //    }

    //}
    //class Shopping
    //{
    //    public List<User> Users = new List<User>()
    //    {
    //        new User()
    //        {
    //            UserName="A",
    //            Password="123",
    //            Orders=new List<Product>()
    //        },
    //        new User()
    //        {
    //            UserName="B",
    //            Password="14323",
    //               Orders=new List<Product>()
    //        },
    //        new User()
    //        {
    //            UserName="C",
    //            Password="12314",
    //               Orders=new List<Product>()
    //        },
    //    };
    //    public List<Product> Products = new List<Product>()
    //    {
    //        new Product()
    //        {
    //            ID="1",
    //            Name="Iphone"
    //        },
    //        new Product()
    //        {
    //              ID="2",
    //            Name="Playstation"
    //        },
    //        new Product()
    //        {
    //             ID="3",
    //            Name="Laptop"
    //        },
    //    };
    //    public void Login(string password)
    //    {

    //        bool result = Users.Any(x => password == x.Password);

    //        Product currentProduct;

    //        User currentUser = null;
    //        if (result)
    //        {

    //            foreach (var item in Users)
    //            {
    //                if (item.Password == password)
    //                {

    //                    currentUser = item;
    //                }


    //            }
    //            Console.WriteLine("Welcome");
    //            Console.WriteLine("Please select product");
    //            foreach (var item in Products)
    //            {
    //                Console.WriteLine(item.Name);
    //            }
    //            string productName = Console.ReadLine();
    //            bool result2 = Products.Any(x => productName == x.Name);
    //            var productExists = Products.Find(x => x.Name == productName);
    //            if (productExists != null)
    //            {
    //                Console.WriteLine($"{productName} ordered");
    //                foreach (var item in Products)
    //                {
    //                    if (item.Name == productName)
    //                    {
    //                        currentProduct = item;

    //                        currentUser.Orders.Add(currentProduct);
    //                        currentUser.ShowMyProducts();

    //                    }
    //                }

    //            }
    //            else
    //            {
    //                Console.WriteLine("Product doesn't exists");
    //            }


    //        }
    //        else
    //        {
    //            Console.WriteLine("User doesn't exists");

    //        }

    //    }
    //}
}

