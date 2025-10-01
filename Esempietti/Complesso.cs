using Esempietti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempietti
{
    class Complesso
    {
        public double R { get; set; }
        public double I { get; set; }

        public Complesso() { }
        public Complesso(double reale, double immaginario)
        {
            this.R = reale;
            this.I = immaginario;
        }

        public static Complesso Add(Complesso c1, Complesso c2)
        {
            Complesso cSomma = new Complesso();
            cSomma.R = c1.R + c2.R;
            cSomma.I = c1.I + c2.I;

            return cSomma;
        }

        public static Complesso Sub(Complesso c1, Complesso c2)
        {
            Complesso cSottrazione = new Complesso();
            cSottrazione.R = c1.R - c2.R;
            cSottrazione.I = c1.I - c2.I;

            return cSottrazione;
        }

        public static Complesso Mul(Complesso c1, Complesso c2)
        {
            Complesso cMoltiplicazione = new Complesso();
            cMoltiplicazione.R = (c1.R * c2.R) - (c1.I * c2.I);
            cMoltiplicazione.I = (c1.R * c2.I) + (c1.I * c2.R);

            return cMoltiplicazione;
        }

        /*
        public static Complesso.Div(Complesso c1, Complesso c2)
        {
            Complesso cDivisione = new Complesso();
            cDivisione.R = ;
            cDivisione.I = ;

            return cDivisione;
        }
        */
        public static Complesso Parse(string s)
        {
            s = s.Replace(" ", "").ToLower();

            double r = 0, i = 0;

            // Numero con una parte immaginaria
            if (s.EndsWith("i"))
            {
                string imagPart = s.Substring(0, s.Length - 1);
                if (imagPart == "" || imagPart == "+")
                    i = 1;
                else if (imagPart == "-")
                    i = -1;
                else
                {
                    // Check for real+imaginary (e.g. "5+3i", "5-3i", "+5+3i", "-5-3i")
                    int plus = imagPart.LastIndexOf('+');
                    int minus = imagPart.LastIndexOf('-');
                    //int split = Math.Max(plus, minus > 0 ? minus : -1);
                    int split = Math.Max(plus, minus);

                    if (split > 0)
                    {
                        string realStr = imagPart.Substring(0, split);
                        string imagStr = imagPart.Substring(split);
                        double.TryParse(realStr, out r);
                        double.TryParse(imagStr, out i);
                    }
                    else
                    {
                        double.TryParse(imagPart, out i);
                    }
                }
            }
            else
            {
                // Pure real (e.g. "5", "-5", "+5")
                double.TryParse(s, out r);
            }

            var complesso = new Complesso();
            complesso.I = i;
            complesso.R = r;
            return complesso;
        }
    }
}
