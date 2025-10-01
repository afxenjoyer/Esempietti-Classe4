using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempietti
{
    internal class Quadrato
    {
        private float _lato;

        public float Lato
        {
            get
            {
                return _lato;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Il lato deve essere un numero positivo");
                }
                _lato = value;
            }
        }

        public float CalcolaArea()
        {
            return CalcolaArea(_lato);
        }

        public static float CalcolaArea(float lato)
        {
            return lato * lato;
        }

        public static float CalcolaArea(Quadrato q)
        {
            return q.Lato * q.Lato;
        }

    }
}
