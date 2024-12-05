using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaObjekti002
{
    using System;

    public class Zrakoplov
    {
        private string ime;
        private double snagaMotora;
        private int dosegLeta;

        public Zrakoplov(string ime, double snagaMotora, int dosegLeta)
        {
            ime = this.ime;
            snagaMotora = this.snagaMotora;
            dosegLeta = this.dosegLeta;
        }

        public override string ToString()
        {
            return $"Naziv: {ime}, Snaga motora: {snagaMotora} kW, Doseg leta: {dosegLeta} km";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC21 = new Zrakoplov("Pilatus", 1200, 1333);

            Console.WriteLine(x380.ToString());
            Console.WriteLine(C162.ToString());
            Console.WriteLine(PC21.ToString());
        }
    }

}