using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esempietti
{
    class Contatore
    {
        private int _numero = 0;

        public int ProssimoNumero
        {
            get
            {
                _numero++;
                return _numero;
            }
        }

        public void Reset()
        {
            _numero = 0;
        }
    }
}
