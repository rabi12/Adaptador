using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Adaptador
{
    public class TotalDecimal:ITotalDecimal
    {
        decimal ITotalDecimal.getTotal()
        {
            return 1000;
        }
    }
}
