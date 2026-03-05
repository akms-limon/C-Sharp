using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _03_static_non_static_variables
{
    /***********Static and Non Static Variables******/

    /* Declaration scope of static variables ->
     * To access static variable don't need to make any instance of the class, but for the non static variable, at first have to make a instance of class then it can be access.

     * If we declare a static variable in a scope/block then we can't use this variable in other scope/block
     
     * Static variable can be access from another static method 

     * And if we declare a variable inside a static block, then also that variable is a static variable.
     */
    internal class Program
    {
        static int x = 10; // static variable (can be access from Program class only
        int y = 20; // non static variable

        // Read only variable -> there is only two way to set the value of readonly variable 1. when declare, 2. through constructor.... There is no another way to assign value on the readonly variable. 
        readonly int p = 20, q;

        // q = 10; invalid assignment on readonly variable.
        Program()
        {
            p = x;
            q = y;
        }

        static void test()
        {
            Console.WriteLine(x); // static variable can be access from another static or public scope of the same scope of static variable
        }
        static void Main(string[] args)
        {
            int z = 30; // static variable
            test(); // access static method from another static method in same same class. cause they are both are in same scope

            Console.WriteLine(x); // no object needed to print the static variable

            Program obj = new Program();
            Console.WriteLine(obj.y); // to access the non static variable needs to create object of the base class.

            
             // declare and assign value to p
            Console.WriteLine(obj.p); // use p to avoid CS0168
        }
    }
}
