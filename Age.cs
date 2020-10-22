using System;

public class Age{
    public static void age_of_people()
    {
            Console.WriteLine("Please enter your age to know movie prices");
            String userInput=Console.ReadLine();
            int age=Convert.ToInt32(userInput);
            double price=0;
            if (age<=5);
            else if(age>5 && age<=14)
            price=7.99;
            else if(age>14 && age<=65)
            price=11.99;
            else if(age>65)
            price=9.99;
            Console.WriteLine("The ticket for the movie is:$" +price);
    }

}

            