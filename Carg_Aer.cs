using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhafifeJad
{
    internal class Carg_Aer : Cargaison
    {
        public Carg_Aer(int distpar, double p, int tot)
            : base(distpar, p, tot)
        {
        }

        public override double couttrans()
        {
            double cout;
            if(this.total < 80000)
            {
                cout = 10 * this.distancepar * this.poids;
            }
            else
            {
                cout = 12 * this.distancepar * this.poids;
            }
            
            return cout;
        }

        public override void afficher()
        {
            base.afficher();
            Console.WriteLine("Cout AER: " + this.couttrans() + "\n");
        }
    }
}
