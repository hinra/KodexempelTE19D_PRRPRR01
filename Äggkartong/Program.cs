using System;

namespace Äggkartong {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("hur många ägg");
            string input = Console.ReadLine();
            int ägg = int.Parse(input);

            Console.WriteLine("hur stor är kartongen?");
            input = Console.ReadLine();
            int kartong = int.Parse(input);
            int antal = ägg / kartong; 

            if (ägg % kartong == 0 ) {
                // 1. Fall delbar med tolv/kartong
                Console.WriteLine("Du behöver " + antal + " kartonger");
            }
            else {
                // 2. Fall några ägg kvar ( rest vid division) 
                antal++; // höja antal med 1
                Console.WriteLine("Du behöver " + antal + " kartonger");
            }

            Console.ReadLine(); // för att stoppa programmet.
        }
    }
}
