yourmomahoe, [30/11/21 5:46 PM]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Canarys
{
    internal class Frameworks
    {   
        // Class Module
        static void Stackname(string[] args)
        { 
                
            // remove.this

        }

        // Time Module
        static void Timing(string[] args)
        {

            // Buy Time
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
        }

        // Get user input
        static void In(string[] args)
        {
            Console.WriteLine("Username : ");
            string user = Console.ReadLine();

            Console.WriteLine("Password : ");
            string pass = Console.ReadLine();

            Console.WriteLine($"Your username is {user} with the password {pass}. Please, rate our Security system. Your privacy matters.");
        }

    }


    internal class Program
    {
        static void LooperWasted(string[] args)
        {

            //  Wasted For Loop
            for (int i = 1, j = 1; i < 4 && j <= 1; i++)
            {
                Console.WriteLine(i + " " + j);
                Console.WriteLine(i + " " + j * 2);
                Console.WriteLine(i + " " + j * 3);
            }

            Console.ReadLine();
        }


        static void Whiler(string[] args)
        {

            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }

        }


        // Static Operations
        public class StaticOperations
        {
            public void Add()
            {
                int a = 10;
                int b = 20;
                int sum = a + b;
                Console.WriteLine($"The sum of two numbers are : {sum}");
            }

            public void Sub()
            {
                int a = 10;
                int b = 20;
                int sum = a - b;
                Console.WriteLine($"The Sub of two numbers are : {sum}");
            }

            public void Multi()
            {
                int a = 10;
                int b = 20;
                int sum = a * b;
                Console.WriteLine($"The Multiple of two numbers are : {sum}");
            }

            public void Div()
            {
                int a = 10;
                int b = 20;
                int sum = a / b;
                Console.WriteLine($"The Quotient of two numbers are : {sum}");
            }
        }


        // Static Operations
        public class DynamicOperations
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Sub(int a, int b)
            {
                return a - b;
            }

            public int Multi(int a, int b)
            {
                return a * b;
            }

            public int Div(int a, int b)
            {
                return a / b;
            }
        }

        public class Formulas
        {

            public int Rectangle()
            {
                int l = 10;
                int b = 20;
                Console.WriteLine($"Are of the Rectangle is : {l*b}");
                return l * b;
            }

            public int Triangle()
            {
                int b = 10;
                int h = 20;
                Console.WriteLine($"Are of the Triangle is : {b/2} * {h/2}");
                return b / 2* h / 2;
            }

            public float Circle()
            {
                float pi = 3.14f;
                int r = 20;
                float area = pi * r * r;
                Console.WriteLine($"Are of the Rectangle is : {area}");
                return area;
            }

        }

yourmomahoe, [30/11/21 5:46 PM]
static void Main(string[] args)
        {
            Console.WriteLine(@"                
    
            yourmomahoe, [30/11/21 5:46 PM]
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Canarys
{
    internal class Frameworks
    {   
        // Class Module
        static void Stackname(string[] args)
        { 
                
            // remove.this

        }

        // Time Module
        static void Timing(string[] args)
        {

            // Buy Time
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
        }

        // Get user input
        static void In(string[] args)
        {
            Console.WriteLine("Username : ");
            string user = Console.ReadLine();

            Console.WriteLine("Password : ");
            string pass = Console.ReadLine();

            Console.WriteLine($"Your username is {user} with the password {pass}. Please, rate our Security system. Your privacy matters.");
        }

    }


    internal class Program
    {
        static void LooperWasted(string[] args)
        {

            //  Wasted For Loop
            for (int i = 1, j = 1; i < 4 && j <= 1; i++)
            {
                Console.WriteLine(i + " " + j);
                Console.WriteLine(i + " " + j * 2);
                Console.WriteLine(i + " " + j * 3);
            }

            Console.ReadLine();
        }


        static void Whiler(string[] args)
        {

            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }

        }


        // Static Operations
        public class StaticOperations
        {
            public void Add()
            {
                int a = 10;
                int b = 20;
                int sum = a + b;
                Console.WriteLine($"The sum of two numbers are : {sum}");
            }

            public void Sub()
            {
                int a = 10;
                int b = 20;
                int sum = a - b;
                Console.WriteLine($"The Sub of two numbers are : {sum}");
            }

            public void Multi()
            {
                int a = 10;
                int b = 20;
                int sum = a * b;
                Console.WriteLine($"The Multiple of two numbers are : {sum}");
            }

            public void Div()
            {
                int a = 10;
                int b = 20;
                int sum = a / b;
                Console.WriteLine($"The Quotient of two numbers are : {sum}");
            }
        }


        // Static Operations
        public class DynamicOperations
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Sub(int a, int b)
            {
                return a - b;
            }

            public int Multi(int a, int b)
            {
                return a * b;
            }

            public int Div(int a, int b)
            {
                return a / b;
            }
        }


        public class Ops{
          // ADD
            StaticOperations summer = new StaticOperations();
            summer.Add();

            // SUB
            StaticOperations subber = new StaticOperations();
            summer.Sub();

            // MULTI
            StaticOperations multier = new StaticOperations();
            summer.Multi();

            // DIV
            StaticOperations diver = new StaticOperations();
            summer.Div();
        }

        
        public class Formulas
        {

            public int Rectangle()
            {
                int l = 10;
                int b = 20;
                Console.WriteLine($"Are of the Rectangle is : {l*b}");
                return l * b;
            }

            public int Triangle()
            {
                int b = 10;
                int h = 20;
                Console.WriteLine($"Are of the Triangle is : {b/2} * {h/2}");
                return b / 2* h / 2;
            }

            public float Circle()
            {
                float pi = 3.14f;
                int r = 20;
                float area = pi * r * r;
                Console.WriteLine($"Are of the Rectangle is : {area}");
                return area;
            }

        }

yourmomahoe, [30/11/21 5:46 PM]
static void Main(string[] args)
        {
            Console.WriteLine(@"
      ___           ___           ___           ___           ___                       ___     
     /\__\         /\  \         /\  \         /\  \         /\  \                     /\__\    
    /:/  /        /::\  \        \:\  \       /::\  \       /::\  \         ___       /:/ _/_   
   /:/  /        /:/\:\  \        \:\  \     /:/\:\  \     /:/\:\__\       /|  |     /:/ /\  \  
  /:/  /  ___   /:/ /::\  \   _____\:\  \   /:/ /::\  \   /:/ /:/  /      |:|  |    /:/ /::\  \ 
 /:/__/  /\__\ /:/_/:/\:\__\ /::::::::\__\ /:/_/:/\:\__\ /:/_/:/__/___    |:|  |   /:/_/:/\:\__\
 \:\  \ /:/  / \:\/:/  \/__/ \:\~~\~~\/__/ \:\/:/  \/__/ \:\/:::::/  /  __|:|__|   \:\/:/ /:/  /
  \:\  /:/  /   \::/__/       \:\  \        \::/__/       \::/~~/~~~~  /::::\  \    \::/ /:/  / 
   \:\/:/  /     \:\  \        \:\  \        \:\  \        \:\~~\      ~~~~\:\  \    \/_/:/  /  
    \::/  /       \:\__\        \:\__\        \:\__\        \:\__\          \:\__\     /:/  /   
     \/__/         \/__/         \/__/         \/__/         \/__/           \/__/     \/__/    
                                                
                                          [ Developer : Blesslin Jerish R ]
                                              [ Stack : SeeSharp .net ]
                              ");
            Console.WriteLine("");
            Console.WriteLine("Bonjour Canarys");
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine("");
            // Temp Code Below

            

            // Backup To Origin [ ctrl C + ctrl V ]
            // Swap Code Above
            Console.WriteLine("");
            Console.WriteLine("Danks");
            Console.ReadLine(); // Dont't Delete this 
        }
        
    }
}



                                                
                                          [ Developer : Blesslin Jerish R ]
                                              [ Stack : SeeSharp .net ]
                              ");
            Console.WriteLine("");
            Console.WriteLine("Bonjour Canarys");
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString("F"));
            Console.WriteLine("");
            // Temp Code Below

            // ADD
            StaticOperations summer = new StaticOperations();
            summer.Add();

            // SUB
            StaticOperations subber = new StaticOperations();
            summer.Sub();

            // MULTI
            StaticOperations multier = new StaticOperations();
            summer.Multi();

            // DIV
            StaticOperations diver = new StaticOperations();
            summer.Div();

            // Backup To Origin [ ctrl C + ctrl V ]
            // Swap Code Above
            Console.WriteLine("");
            Console.WriteLine("Danks");
            Console.ReadLine(); // Dont't Delete this 
        }
        
    }
}