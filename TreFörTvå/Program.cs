using System;

namespace TreFörTvå {
    class Program {
        static void Main(string[] args) {
            Console.Write("Pris 1:");
            double pris1 = double.Parse(Console.ReadLine());
            Console.Write("Pris 2:");
            double pris2 = double.Parse(Console.ReadLine());
            Console.Write("Pris 3:");
            double pris3 = double.Parse(Console.ReadLine());

            double summa = pris1 + pris2 + pris3;
            double billigast = 0; 

            if(pris1 < pris2) {
                billigast = pris1;
            }
            else{
            billigast = pris2;
            }

            if(pris3 < billigast){
                billigast = pris3;
            }

            double slutsumma = summa - billigast;
            double vinstProcent = (1- slutsumma / summa) * 100;

            Console.WriteLine("Ursprunglig totalsumma: " + summa);
            Console.WriteLine("Du betala: " + slutsumma);
            Console.WriteLine("Du sparar " + billigast + "kr, i %: " + vinstProcent);
             
            Console.ReadLine();

        }
    }
}
