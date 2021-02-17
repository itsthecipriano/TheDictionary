using System;
using System.Collections.Generic;

namespace TheDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> theSurname = new Dictionary<int, string>();
            theSurname.Add(25, "Atmaca");
            theSurname.Add(21, "Arslan");
            theSurname.Add(19, "Şahin");


            Surname<int, string> surname = new Surname<int, string>();
            surname.Add(17, "Koç");

            surname.List();
            int result = surname.Count;
            Console.WriteLine(result);

        }
    }
}
