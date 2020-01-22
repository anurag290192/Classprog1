using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            //max Heart rate is equal to 220-age
            age = 27;
            height = 158;
            int heartrate;
            heartrate = 220 - age;
            Console.WriteLine("I am " + age + "years old , my max heart rate" +  heartrate);

            

        
            Console.ReadLine();
            

        }
    }
}
