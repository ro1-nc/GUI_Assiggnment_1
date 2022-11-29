using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAssignment
{
    class Program
    {
        static void Main(string[] args)
        {         
            string name = Input_display("Please enter your name");
            string fav_phrase =Input_display("Please enter your favourite phrase");

            Display_output(name, fav_phrase);
            Console.ReadLine();
        }
        public  static string Input_display(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        public static void Display_output(string name, string phrase)
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><>");
            Console.WriteLine("Your name is "+name);
            Console.WriteLine("Your favourite phrase is " + phrase);
            Console.WriteLine("<><><><><><><><><><><><><><><><>");
        }
    }
}
