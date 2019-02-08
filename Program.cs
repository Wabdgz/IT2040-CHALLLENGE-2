using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
             const byte sample1 = 0x3A;
            const float acceleration = 9.800F;
            const char integral = '\u222B';
            const string greeting = "Hello";

             string name;
             name = "Karen";

             byte sample2;
             sample2 = 58;

            int HeartRate, choice, i, age;
            HeartRate = 85;
            choice = 2;
            age = 0;

            float mass;
            mass = 14.6F;

            float force;
            force = mass * acceleration;

            double deposits, distance;
            deposits = 135002796;
            distance = 129.763001;

            bool lost, expensive;
            lost = true;
            expensive = true;

             if (sample1 == sample2)
             {Console.WriteLine("The samples are equal.");}
             else {Console.WriteLine("The samples are not equal.");}

            //HeartRate
            if (HeartRate >= 40 && HeartRate <= 80)
            { Console.WriteLine("Heart Rate is normal.\n"); }
            else { Console.WriteLine("Heart rate is not normal.\n"); }

            //Deposits
            if (deposits >= 100000000)
            { Console.WriteLine("you are exceedingly wealthy.\n"); }
            else { Console.WriteLine("Sorry you are broke.\n"); }

            //Force
            Console.WriteLine("Force =");
            Console.Write(force);
            Console.WriteLine("\n");

            //distance
            Console.Write(distance);
            Console.WriteLine("is the distance.\n");

            //lost and expensive
            if (lost == true || expensive == true)
            { Console.WriteLine("I am really sorry! I'll get the manager.\n"); }

            else if (lost == true || expensive == false)
            { Console.WriteLine("Here is a Coupon for 10% off.\n"); }

            //Integral
            Console.Write(integral);
            Console.WriteLine(" is an Integral.\n");

            for (i = 5; i < 11; i++)
            {
                Console.WriteLine("i={0}",i);
            }

            while(age <= 6)
            {
                for(age=0;age<7;age++)
                Console.WriteLine("age = {0}", age);

                
              
            }

            Console.WriteLine("{0} {1}", greeting, name);
            Console.WriteLine("\n");
            
            //Choice
            //Console.WriteLine("\nPlease make a choice:\n");
            //choice = Convert.ToInt32(Console.ReadLine());

            //choice
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("You chose 1.\n");
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("You chose 2.\n");
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("You chose 3.\n");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("You made an unkown choice.\n");
                        break;
                    }
                   
            }
            Console.ReadLine();
        }
    }
}
