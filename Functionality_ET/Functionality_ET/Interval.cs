using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality_ET
{
    public class Interval
    {
        public string Name { get; }
        public int Semitones { get; }

        public Interval(string name, int semitones)
        {
            Name = name;
            Semitones = semitones;
        }
    }
}
