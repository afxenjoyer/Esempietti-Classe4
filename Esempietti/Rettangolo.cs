using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempietti
{
    public class Rettangolo
    {
        public float Lato1 { get; set; }

        public float Lato2 { get; set; }

        public bool IsQuadrato()
        {
            return Lato1 == Lato2;
        }
    }
}
