using System;
using System.Collections.Generic;
using System.Text;

namespace Patron_Adaptador
{
    public class TotalString : ITotalString
    {
        public string getTotal()
        {
            return "1000";
        }
    }
}
