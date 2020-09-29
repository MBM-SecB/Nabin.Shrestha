using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main()

        {
            //LINQ-Language Integrated  Query

            int[] numbers = { 11, 22, 32, 13, 53, 65, 76, 34, 21, 65, 342, 33 };

            //method syntax
            var result1 = numbers.Where(num => num > 50).Select(num => num);

            //query expression syntax

            var result2 = from num in numbers
                          where num > 50
                          select num;



            //restrication - where    

            var result3 = from num in numbers
                          where num > 50 && num < 70
                          select num;


            //projection -select 
            var result4 = from num in numbers
                          select num * num;


            var result5 = from num in numbers
                          where num % 2 == 0
                          select num * num;

            //ordering- orderby, orderby desending

            var result6 = from num in numbers
                              //for desending order of even number: where num % 2 == 0
                          orderby num descending
                          select num;

            //Partitioning: take 
            var result7 = numbers.Take(5);//(take 1st 5 numbers)

            var result8 = numbers.Skip(5).Take(5);//(skip 1st 5 numbers and take 5 number after that)


            var result9 = numbers.Any(num => num % 2 == 0);//(any element even)

            var result10 = numbers.All(num => num % 2 == 0);//(checks if all elements are even)

            var results11 = numbers.Contains(23);//(checks if 23 is in element)

            //  Generating:range 
            var result12 = Enumerable.Range(1, 1000);//get 1 to 1000

            var result13 = Enumerable.Repeat("Hello WOrld", 20); //print hello world 20 times



        }


        void LearnLinqOnComplexCollection()
        {
            //List<Country> countries = new List<Country>();

            Country c1 = new Country("Nepal", "Kathmandu", "Asia", 3232323);
            Country c2 = new Country("India", "New Delhi", "Asia", 3232232333, DateTime.Parse("1947/1/1"));
            Country c3 = new Country("US", "WashingtonDC", "NorthAmerica", 323232323);
            Country c4 = new Country("China", "Beijing", "Asia", 2233324232323, DateTime.Parse("1999/2/3"));
            Country c5 = new Country("Bhutan", "A", "Asia", 3232323343);
            Country c6 = new Country("India1", "New Delhi1", "Asia", 323223233233, DateTime.Parse("1947/1/1"));
            Country c7 = new Country("Portugal", "Madrid", "Europe", 323232323323);
            Country c8 = new Country("Spain", "madrid1", "Europe", 223323342323, DateTime.Parse("1888/7/29"));
            Country c9 = new Country("Pakistal", "Pk1", "Asia", 323232334);
            Country c10 = new Country("Bangladesh", "Bg1", "Asia", 3232232333433, DateTime.Parse("1945//9/15"));
            Country c11 = new Country("Germany", "GE1", "Europe", 32323232334);
            Country c12 = new Country("United Kingdom", "Uk1", "South America", 342233232323, DateTime.Parse("1929/12/23"));
            Country c13 = new Country("Australia", "Au1", "Australia", 3232323343);
            Country c14 = new Country("Afganistan", "Af1", "Asia", 32322323343, DateTime.Parse("1908/3/14"));
            Country c15 = new Country("US", "WashingtonDC", "NorthAmerica", 32433232323);
            Country c16 = new Country("SouthKorea", "Sk1", "Asia", 223323232433, DateTime.Parse("1997/8/23"));
            Country c17 = new Country("NorthKorea", "Nk1", "Asia", 3232323453);
            Country c18 = new Country("Argentina", "Ag2", "Europe", 32454232333, DateTime.Parse("1923/5/13"));
            Country c19 = new Country("Russia", "Rs2", "NorthAmerica", 3232323);
            Country c20 = new Country("Netheland", "Nl1", "Europe", 22332323, DateTime.Parse("1932/6/2"));


            //c1.Name="Nepal";
            //c1.Capitol="Kathmandu";
            //c1.Continent ="Asia";
            //c1.Population = "3232323";

            //countries.Add(c1);

            var countries = new List<Country> { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20 };


            var resultl9 = from country in countries
                           where country.Continent == "Asia"
                           select country.Name;

            //      HW:1 - list all asian country which are never been invaded
            //      HW:2 - list all europian countries in assending order that has population less than 500k        

            //hw:1
            var result23 = from country in countries
                           where country.IndependenceDay == default
                           select country.Name;


            //hw:2
            var result21 = from country in countries
                           orderby country.Population
                           where country.Continent == "Europe"
                           select country.Name;

        }

    }
}