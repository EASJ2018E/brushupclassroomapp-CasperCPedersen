using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn { get; set; }

        public List<Studerende> KlasseList { get; set; }

        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
            KlasseList = new List<Studerende>();
        }

    }
}
