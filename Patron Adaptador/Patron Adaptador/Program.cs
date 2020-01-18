using System;

namespace Patron_Adaptador
{
    class Program
    {
        static void Main(string[] args)
        {
            ITotalString servicio = new TotalString();

            Adapter adaptador = new Adapter(servicio);
            decimal resultado = adaptador.getTotal();

            Console.WriteLine("Resultado:"+resultado);

            Console.ReadKey();
        }
    }
}
