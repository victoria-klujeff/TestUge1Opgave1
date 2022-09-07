using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop
{
    public class Rabatberegner
    {
        public double GetPrisEfterRabat(int antalVarer, double stykPris)
        {
            double bruttoPris = antalVarer * stykPris;
            if (bruttoPris > 1000 && antalVarer <= 10)
            {
                // Indkøb over 1000 kr. giver 3% rabat
                double rabat = bruttoPris * 0.03;
                bruttoPris = bruttoPris - rabat;
            }
            if (antalVarer > 10 && bruttoPris <= 1000)
            {
                // Flere end 10 varer giver 2% rabat
                double rabat = bruttoPris * 0.02;
                bruttoPris = bruttoPris - rabat;
            }
            if (antalVarer > 10 && bruttoPris > 1000)
            {
                double rabat = bruttoPris * 0.05;
                bruttoPris = bruttoPris - rabat;
            }

            return bruttoPris;
        }

        public double GetPriceAfterDiscount(int antalVarer, double stykPris)
        {
            double bruttoPris = antalVarer * stykPris;
            double discount = 0;

            if (bruttoPris > 1000)
            {
                discount += 0.03;
            }
            if (antalVarer > 10)
            {
                discount += 0.02;
            }
            bruttoPris -= (bruttoPris * discount);
            return bruttoPris;
        }
        
    }
}
