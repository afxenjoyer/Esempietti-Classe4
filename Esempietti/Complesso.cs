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

        // Formati
        // 5+3i
        // 5-3i
        // 5
        // 3i
        // -3i
        // +5
        // -5
        // -5-3i
        // -5+3i
        // +5
        // +5-3i
        // +5+3i
        // i
        // -i
        // +i
        public static Complesso Parse(string s)
        {
            s = s.Replace(" ", "").ToLower();

            double r = 0, i = 0;

            // Numero con una parte immaginaria
            if (s.EndsWith("i"))
            {
                // 5+3i
                // 5-3i
                // 3i
                // -3i
                // -5-3i
                // -5+3i
                // +5-3i
                // +5+3i

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
