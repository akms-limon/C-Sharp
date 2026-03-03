using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Data types in c#
                Boolean, char, string
                byte: 1 byte (8 bits)
                short/Int16: 2 bytes (16 bits)
                int/Int32: 4 bytes (32 bits)
                float: 4 bytes (32 bits)
                long/Int64: 8 bytes (64 bits)
                double: 8 bytes (64 bits)
                decimal: 16 bytes (128 bits)
            */

            /* Default value of all variable is zero
             but for char it is null */

            
            
            //***********Convertion of datatypes*********//


            /*Implicit convertion/Direct assign:
              Assign the smaller size variable in a greater one example: 
            */
            int x = 10;
            double y = x;

            
            /* Explicit (assign bigger to lower) / I have to type cast in that case. if the bigger element is greater than the smaller datatypes size. then it will lose data */
            
            double p = 1000;
            int q = (int)p;

            byte b = (byte)q; // lose of data

            
            /* Conversion with the helper methods*/

            
            /* Using Convert Class
            ToBoolean, ToChar, ToByte, ToDecimal, ToDouble, ToInt16, ToInt32, ToInt64, ToString, ToUInt16, ToUInt32, ToUInt64, DateTime
            
            *These methods can handle null 
            *but Throw exception when it get an invalid conversion
                example: int x = Convert.ToInt32("1dihf");
            */

            string s = "name";
            //int z = Convert.ToInt32(s); // will throw a exception
            string another = "100";
            int z = Convert.ToInt32(s);


            /* Convertion using Parse() method
             * If the convertion is invalid then it will crash*/

            x = int.Parse(s);
            y = double.Parse("10.5");
            DateTime dt = DateTime.Parse("2026-03-03");


            /* Convertion using TryParse() method
             * It is the best practice for convertion
             * Safe convertion no crash will happen
             */

            bool success = int.TryParse(s, out x);

            if (success)
            {
                Console.WriteLine("Converted Successfully!");
            }
            else
            {
                Console.WriteLine("Invalid Convertion.");
            }
        }
    }
}
