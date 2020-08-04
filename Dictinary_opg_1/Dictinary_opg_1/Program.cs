using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // initialize data.
        Dictionary<string, int> data = new Dictionary<string, int>()
        {
            {"Superman", 1},
            {"Batman", 2},
            {"Green_Arrow", 3},
            {"Aquaman", 4},
            {"Ravem", 5},
            {"Cyborg", 6},
            {"Beastboy", 7},
            {"Swamp_Thing", 8},
            {"Robin", 9},
            {"Robocop", 10}
        };

        // Store keys in a List.
        var list = new List<string>(data.Keys);
        // Loop through the List.
        foreach (string key in list)
        {
            Console.WriteLine("KEY FROM LIST: " + key);
        }


        // Loop over pairs with foreach.
        foreach (KeyValuePair<string, int> pair in data)
         {
             Console.WriteLine("FOREACH KEYVALUEPAIR: {0}, {1}", pair.Key, pair.Value);
         }

        // Use var keyword to enumerate Dictionary.
        /* foreach (var pair in data)
         {
             Console.WriteLine("FOREACH VAR: {0}, {1}", pair.Key, pair.Value);
         }*/
    }
}