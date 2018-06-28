using System;
using static System.Console;
namespace Basic_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            double No1, No2, No3, no4, no5, no6;
            No1 = double.Parse(ReadLine());
            No2 = double.Parse(ReadLine());
            No3 = double.Parse(ReadLine());
            no5 = No3 / 57.295675;
            Clear();
            WriteLine("Enter Corresponding digit");
            no4 = double.Parse(ReadLine());
            Clear();
           if (no4 == 1)
            {
                WriteLine(No1+No2);
            }
            else if(no4==2)
            {
                WriteLine(No1-No2);
            }
            else if(no4==3)
            {
                WriteLine(No1*No2);
            }
            else if(no4==4)
            {
                WriteLine(No1/No2);
            }
            else if(no4==5)
            {
                WriteLine(No1%No2);
            }
            else if(no4==6)
            {
                WriteLine(Math.Sign(no5));
            }
            else if(no4==7)
            {
                WriteLine(Math.Cos(no5));
            }
            else if(no4==8)
            {
                WriteLine(Math.Tan(no5));
            }
            
            

            ReadKey();


        }
    }
}