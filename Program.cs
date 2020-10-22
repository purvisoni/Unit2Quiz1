using System;

namespace movie
{
    
    class Program
    {
        static void Main(string[] args)
        {
           //Age.age_of_people(); 
           Movie movie1=new Movie("Stranger Things","Stephan Knapp", 2019, 1);
           movie1.getRating();
           movie1.AvgRating();
            
        }
    }
    
}
