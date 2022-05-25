using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhafifeJad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cargaison> Carg = new List<Cargaison>();
            Carg.Add(new Carg_Aer(1200,9,1000));
            Carg.Add(new Carg_Rout(1500, 10,38000));
            Carg.Add(new Carg_Aer(1700, 12, 90000));

            foreach(Cargaison car in Carg)
            {
                car.afficher();
            }


            Console.ReadKey();
        }
    }
}
