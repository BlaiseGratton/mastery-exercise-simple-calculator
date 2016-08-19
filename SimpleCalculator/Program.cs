using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialise necessary objects
            RegexParser parser = new RegexParser();
            Evaluator eval = new Evaluator();


            while(true)
            {
                //interact with user
                Console.WriteLine("Enter an expression");
                string input = Console.ReadLine();

                //evaluate input
                try
                {
                    parser.ParseInput(input);
                    string result = eval.Calculate(parser.Term2, parser.Term2, parser.Operator);
                    Console.WriteLine(result);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
