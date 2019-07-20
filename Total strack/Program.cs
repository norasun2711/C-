using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_strack
{
    public struct s_total
    {
        public string name;
        public int qty;
        public float price;
       public float amount()
        {
           return qty * price; 
        }
        public void input()
        {
            Console.Write("Enter Name : "); name = Console.ReadLine();
            Console.Write("Enter Qty  : ");qty = int.Parse(Console.ReadLine());
            Console.Write("Enter Price: "); price = int.Parse(Console.ReadLine());
            Console.Write("Amount: " + amount() + "$");
            Console.Write("\n---------------------------------------\n");
        }
        public void output()
        {
            Console.WriteLine(name + "\t" + qty + "\t" + price + "\t" + amount()+"$");
            //Console.WriteLine("\n------------------------------------\n");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            s_total[] a = new s_total[10];
            Console.Write("Enter n: "); n = int.Parse(Console.ReadLine());
            for(int i=0;i< n; i++)
            {
                a[i].input();
            }
            double total=0;
            Console.WriteLine("Name\t" + "Qty\t" + "Price\t" + "amount");
            for(int i=0;i< n; i++)
            {
                a[i].output();
                total += a[i].amount();
            }
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("\t\t\t\tTotal: {0}$", total);
            Console.ReadKey();
            
        }
    }
}
