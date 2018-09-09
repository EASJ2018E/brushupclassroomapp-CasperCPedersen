using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string Name { get; set; }

        public int FødeslsMåned { get; set; }

        public int FødeslsDag { get; set; }

        public Studerende(string name, int fødeslsMåned, int fødeslsDag)
        {
            Name = name;
            FødeslsMåned = fødeslsMåned;
            FødeslsDag = fødeslsDag;
        }
    }
}
