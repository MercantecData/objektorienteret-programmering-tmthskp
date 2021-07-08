using System;
using System.Collections.Generic;

namespace _1st_Dictionary
{
    class Program_1stDictionary
    {
        static void Main(string[] args)
        {
            // måde hvorpå man kan tilføje data til et dictionary
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

            // Tests af sammensætninger til visning
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

            // Use var keyword to view Dictionary.
            foreach (var pair in data)
            {
                Console.WriteLine("FOREACH VAR: {0}, {1}", pair.Key, pair.Value);
            }


            // Gennemgang af dictionary i klassen anden måde at gøre det på
            var ageOfStudents = new Dictionary<string, int>();

            ageOfStudents["Tommy"] = 37;
            ageOfStudents["Mads"] = 29;
            ageOfStudents["Bob"] = 27;
            ageOfStudents["Flop"] = 20;
            ageOfStudents["Sam"] = 17;
            ageOfStudents["Clam Jr"] = 19;
            ageOfStudents["Clam"] = 42;
            ageOfStudents["Clop"] = 20;
            ageOfStudents["Bloat"] = 17;
            ageOfStudents["Dex"] = 19;

            // Loop over pairs with foreach.
            foreach (KeyValuePair<string, int> pair in ageOfStudents)
            {
                Console.WriteLine("FOREACH KEYVALUEPAIR: {0}, {1}", pair.Key, pair.Value);
            }

            Console.WriteLine(ageOfStudents[Console.ReadLine()]);


            // booleans with float as keys
            var booleanFloats = new Dictionary<float, bool>();

            booleanFloats[1f] = true;
            booleanFloats[2f] = false;
            booleanFloats[3f] = true;
            booleanFloats[4f] = false;
            booleanFloats[5f] = true;
            booleanFloats[6f] = false;
            booleanFloats[7f] = true;
            booleanFloats[8f] = false;
            booleanFloats[9f] = true;
            booleanFloats[10f] = false;

            // Use var keyword to enumerate Dictionary.
            foreach (var pair in booleanFloats)
            {
                Console.WriteLine("FOREACH VAR: {0}, {1}", pair.Key, pair.Value);
            }
        }
    }
}
