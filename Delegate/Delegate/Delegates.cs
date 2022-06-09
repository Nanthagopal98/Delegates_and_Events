using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate int dele(int x, int y);
    public class Delegates
    {       
        public int NonStatic(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("using Non Static Addition " + c);
            return c;
        }
        public static int StaticMethod(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("using Non Static Addition " + c);
            return c;
        }
        public static int add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("using Non Static Addition " + c);
            return c;
        }

        public static void Main(string[] args)
        {
            dele delobj = Delegates.StaticMethod;            
            delobj(10, 20);
            delobj(50, 20);
            Delegates de = new Delegates();
            delobj = de.NonStatic;
            delobj(100, 50);
        }
    }
    
}
