using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecse428_AssignmentB
{
    class Program
    {
        static void Main()
        {
            DataSheet.init();
            Console.WriteLine("Please input your package information separated with spaces without parenthesis and a number for post type:");
            Console.WriteLine("Posttype: 0:Regular  1:Xpress  2:Priority");
            Console.WriteLine("(From) (To) (Length) (Width) (Height) (Weight) (Posttype)");
            while (true)
            {
                string[] args = Console.ReadLine().Split(' ');
                switch (args.Length)
                {
                    case 1:
                        if (args[0].Equals("exit"))
                        {
                            System.Environment.Exit(0);
                        }
                        break;
                    case 7:
                        try
                        {
                            Console.WriteLine(Calc.getPrice(new package(args[0], args[1], args[2], args[3], args[4], args[5], args[6])));
                        }
                        catch (FormatException e)
                        {

                            Console.WriteLine("please verify your input information (number format)");
                        }
                        finally
                        {
                            Console.WriteLine("to exit, write exit");
                        }
                        break;
                    default:
                        Console.WriteLine("please provide input in this format");
                        Console.WriteLine("(From) (To) (Length) (Width) (Height) (Weight) (Posttype)");
                        break;
                }
            }
            

        }
    }
}
