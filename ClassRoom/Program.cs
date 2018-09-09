using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum TestKlasse = new KlasseRum();
            TestKlasse.KlasseNavn = "3B";
            DateTime semesterstart = new DateTime(2018,9,4);
            TestKlasse.SemesterStart = semesterstart;
            Studerende Casper = new Studerende("Casper",6,29);
            TestKlasse.KlasseList.Add(Casper);
            Studerende Søren = new Studerende("Søren",1,1);
            TestKlasse.KlasseList.Add(Søren);

        }
    }
}
