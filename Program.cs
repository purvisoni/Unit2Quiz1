using System;

namespace movie
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter your age to know movie prices");
            String userInput=Console.ReadLine();
            int age=Convert.ToInt32(userInput);
            if (age<=5)
            Console.WriteLine("The ticket is free");
            else if(age>5 && age<=14)
            Console.WriteLine("The ticket for the movie is $7.99");
            else if(age>14 && age<=65)
            Console.WriteLine("The ticket for the movie is $11.99");
            else if(age>65)
            Console.WriteLine("The ticket for the movie is $9.99");
        }
    }
}
