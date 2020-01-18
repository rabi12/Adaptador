using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Adaptador
{
    class Adapter : ITotalDecimal
    {
        ITotalString servicio;
        public Adapter(ITotalString servicio)
        {
            this.servicio = servicio;
        }
        public decimal getTotal()
        {
            string totalCadena=servicio.getTotal();
            return decimal.Parse(totalCadena);
        }
    }
}
