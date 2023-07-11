using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UserName;
            Console.WriteLine("Enter User Name");
            UserName = Console.ReadLine();
            if(UserName.Length>=6)
            {
                Console.WriteLine("Welcome : \t" + UserName);
            }
            else
            {
                Console.WriteLine("Invalid User Name");
                goto Again;
            }
            Console.ReadKey();
        }
    }
}
