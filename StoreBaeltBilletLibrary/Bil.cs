using System;
using System.Reflection.Metadata.Ecma335;
using BilletLibrary;

namespace StoreBaeltBilletLibrary
{
    public class Bil : KøretøjSuperClass
    {
        public string dayOfTheWeek { get; set; }
        public override string Nummerplade { get; set; }
        public override DateTime Dato { get; set; }

        public override double Pris()
        {
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }

        public override double BroBizz()
        {
            return Pris() * 0.95;
        }

        public double WeekendRabat()
        {
            if (dayOfTheWeek == "Lørdag" || dayOfTheWeek == "Søndag")
            {
                return 0.80;
            }
            else
            {
                throw new ArgumentException("Denne rabat gælder kun i weekenden (lørdag og søndag).");
            }
        }

        public double TilbudWeekend()
        {
            return Pris() * WeekendRabat();
        }
    }
}
