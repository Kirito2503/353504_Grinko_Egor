using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality_ET
{
    public class Tonality
    {
        public string Name { get; }
        public string Chord { get; }
        public string KeySignature { get; }

        public Tonality(string name, string chord, string keySignature)
        {
            Name = name;
            Chord = chord;
            KeySignature = keySignature;
        }
    }
}
