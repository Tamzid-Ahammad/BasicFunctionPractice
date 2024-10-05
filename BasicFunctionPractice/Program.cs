using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionPractice Q1 = new FunctionPractice();

            Q1.Show();

            string thought = Console.ReadLine();

            Q1.Show(thought);

            Q1.DoSomeCalculation("Okk. I understand how you feeling right now .\nBut can you show me What will be the summation of 13 and 87");

            Console.WriteLine("Please give a value for num1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please give a value for num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Q1.Add(num1, num2);


            Console.ReadLine();

        }
    }
    public class FunctionPractice
    {
        public void Show()
        {
            Console.WriteLine("How are you today");
            //Remember for void type there will be no return type
        }
        public void Show(string text)
        {
            Console.WriteLine($"What can I say ! Hmmm......  {text}\n");
        }
        public string DoSomeCalculation(string text)
        {
            Console.WriteLine($"{text}");
            return text;
        }

        public int Add (int a , int b)
        {
            var c = a + b;
            Console.WriteLine($"{c}");
            return c;
        }

    }
}
