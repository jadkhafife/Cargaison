using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhafifeJad
{
    class Carg_Rout : Cargaison
    {
        public Carg_Rout(int distpar, double p, int tot)
            :base(distpar, p, tot)
        {
        }
        public override double couttrans()
        {
            double cout;
            if (this.total < 380000)
            {
                cout = 4 * this.distancepar * this.poids;
            }
            else
            {
                cout = 6 * this.distancepar * this.poids;
            }

            return cout;
        }

        public override void afficher()
        {
            base.afficher();
            Console.WriteLine("Cout ROUT: " + this.couttrans() + "\n");
        }
    }
}
