using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formTAmita
{
    class hargapaket
    {
        private decimal harga;

        public void setharga(decimal harga)
        {
            this.harga = harga;
        }
        public decimal getharga()
        {
            return harga;
        }
    }
}
