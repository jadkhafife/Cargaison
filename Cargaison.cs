using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhafifeJad
{
    abstract class Cargaison
    {
        private static int count = 0;
        private int reference;
        protected int distancepar;
        protected double poids;
        protected int total;
        public Cargaison(int distpar, double p, int tot)
        {
            this.reference = ++count;
            this.poids = p;
            this.distancepar = distpar;
            this.total = tot;
        }
        public abstract double couttrans();
        public virtual void afficher()
        {
            Console.WriteLine("Reference: " + this.reference + "\n" + "Poids: " + this.poids + "\n" + "Distance Parcourue: " + this.distancepar + "\n" + "Total: " + this.total);
        }
    }
}
