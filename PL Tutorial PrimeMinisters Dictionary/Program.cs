using System;
using System.Collections.Generic;

namespace PL_Tutorial_PrimeMinisters_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary with a string key
            var primerMinisters = new Dictionary<string, PrimeMinister>
            {
                //proper way for creating dictionary elements (key + value)
                {"JC", new PrimeMinister("James Callaghan", 1976) },
                {"MT", new PrimeMinister("Margaret Thatcher", 1979) },
                {"TB", new PrimeMinister("Tony Blair", 1997) }
            };
            

            //assigns the value to "pm" using the "out" parameter
            PrimeMinister pmDc;
            bool found = primerMinisters.TryGetValue("DC", out pmDc);
            // = if "bool found" resolved as true and value was assigned: ...
            if (found)
                //note we display "pm" not "found"
                Console.WriteLine(pmDc.ToString());
            else
            Console.WriteLine("Value not found in Dictioary" + "\r\n");
            //you can enumerate either the key or the value
            foreach (var pPm in primerMinisters)
                Console.WriteLine(pPm.Key + ",    " + pPm.Value);
            Console.WriteLine();


            //using TKey ro replace the elements TValue
            primerMinisters["JC"] =
                new PrimeMinister("Jim Callaghan", 1976);
            //example of displaying the value of the elements only
            foreach (var pmJc in primerMinisters.Values)
                Console.WriteLine(pmJc);
            Console.WriteLine();


            //using TKey to add NewKey & NewValue
            primerMinisters.Add("AM", new PrimeMinister("Andrei Mungiu", 2017));
            foreach (var pAm in primerMinisters)
                Console.WriteLine(pAm);
        }
    }
}
