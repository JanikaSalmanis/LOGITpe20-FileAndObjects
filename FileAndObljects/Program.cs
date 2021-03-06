﻿

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;




namespace FileAndObljects
{
    class Program
    {
        class Movie
        {
           public string title;
            public string rating;
            public string year;

            public Movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"MovieTV.txt";
            //a list to store the movies from the file
            List<string> movielist = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();
            List<Movie> listOfMovies = new List<Movie>();

            foreach (string movieintem in movielist)
            {
                string[] tempArray = movieintem.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie(tempArray[0], tempArray[1], tempArray[2]);
                listOfMovies.Add(newMovie);


            }

            foreach(Movie movie in listOfMovies)
            {
                Console.WriteLine($"title: {movie.title}; rating: {movie.rating}; year: {movie.year}") ;
            }
        }
    }

}
