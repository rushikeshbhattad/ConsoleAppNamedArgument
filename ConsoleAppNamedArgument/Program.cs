using System;

namespace DemoNamedArguement
{
    class Product
    {
        public void PrintOrderDetails(string Sname, int Pid, string Pname)
        {
            Console.WriteLine(Sname + ":" + Pid + ":" + Pname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.PrintOrderDetails(Sname: "Shree Mobile", Pid: 11, Pname: "jerry");
            p1.PrintOrderDetails(Sname: "ganesh Mobile Shop", Pid: 12, Pname: "Cell Phone");
            p1.PrintOrderDetails(Sname: "mobile Shop", Pid: 2, Pname: "tom");
            Console.ReadKey();

        }
    }
}