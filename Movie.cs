using System.Collections.Generic;
using System;
/*
    Challenge:
    - 1. Add a data member for a unique Id to the Movie class
    - 2. Add a data member for a collection of numerical ratings
    - 3. Add a constructor that initializes all the data members of a movie
    - 4. Add a method that allows you to add a rating between 1 and 5 (inclusive) to the movie
    - 5. Add a mechanism that allows you to get the average rating of a movie
    */
public class Movie {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        int Id;
        List<int> Ratings= new List<int>();
        public Movie(string title, string director, int year, int id)
        { 
            Title=title;
            Director=director;
            Year=year;
            Id=id; 
        }
        public void getRating()
        {   while(true)
            { 
                Console.WriteLine("Enter the rating between 1 and 5 for movie, Enter 0 to quit:");
                string input=Console.ReadLine();
                int rating=Convert.ToInt32(input);
                Ratings.Add(rating);
                if(rating==0) break;
            }
        }
        public void AvgRating()
        { 
            int sum=0;
            int i=0;
            for (i=0;i<Ratings.Count;i++)
            sum+=Ratings[i];
            int avg=sum/(i-1);
            Console.WriteLine("The average rating for movie is:"+avg);
        }   
        public void PrintDetails() {
            Console.WriteLine($"Movie Title: {Title}");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Year: {Year}\n");
        }
    }