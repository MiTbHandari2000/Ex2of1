using System;
using System.Collections;

namespace Ex2of1
{
    public class superclass
    {
        List<string> cities = new List<string>
        {
            "Mumbai",
            "Delhi",
            "Ahmedabad",
            "Surat",
            "Valsad",
            "Varanasi",
            "Chennai",
            "Bhopal",
            "Darjeeling",
        };


        public static void Main(string[] args)
        {
            new superclass().runnall();

        }

        private void runnall()
        {


            InDescending(cities);
            InAscending(cities);
            Orderbylength(cities);
            Ascendingbylength(cities);
            NamewithVD(cities);
            Getcount(cities);
            BOTH(cities);
            //FruitsWithColor(clas.fruits);
        }

        private void BOTH(List<string> COMBINE)
        {
            var resultset = cities.GroupBy(c => c[0]);
            Console.WriteLine("CITY NAME WITH FIRST LETTER");
            foreach (var Group in resultset)
            {
                Console.WriteLine(("CityName = " + Group.Key));
                foreach (var cx in Group)
                {
                    Console.WriteLine(cx);
                }
            }
        }



        private void Getcount(List<string> cityname)
        {

            var resultset = cities.Where(c => c[0] == 'A');
            Console.WriteLine("Count with a");

            Console.WriteLine(resultset.Count());

            Console.WriteLine("");
        }

        private void NamewithVD(List<string> cityname)
        {

            var resultset = cities.Where(c => c[0] == 'V' || c[0] == 'D');
            Console.WriteLine("Most Expensive fruits");
            foreach (var name in resultset)
            {
                Console.WriteLine(name);

            }
            Console.WriteLine("");
        }

        private void Ascendingbylength(List<string> city)
        {
            var lengthofcityindescendingt = cities.OrderByDescending(c => c.Length);
            foreach (var fnl in lengthofcityindescendingt)
            {
                Console.WriteLine(fnl);
            }
            Console.WriteLine("");


        }

        private void Orderbylength(List<string> city)
        {
            var lengthofcityindescendingt = cities.OrderBy(c => c.Length);
            foreach (var fnl in lengthofcityindescendingt)
            {
                Console.WriteLine(fnl);
            }
            Console.WriteLine("");


        }
        private void InAscending(List<string> city)
        {
            var ascending = cities.OrderBy(c => c);
            foreach (var ascend in ascending)
            {
                Console.WriteLine(ascend);
            }
            Console.WriteLine("");
        }

        private void InDescending(List<string> city)
        {
            var descending = cities.OrderByDescending(c => c);

            foreach (var fnl in descending)
            {
                Console.WriteLine(fnl);
            }
            Console.WriteLine("");
        }

    }
}