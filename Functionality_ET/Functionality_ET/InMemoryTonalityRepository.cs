using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality_ET
{
    public class InMemoryTonalityRepository : ITonalityRepository
    {
        private readonly List<Tonality> _tonalities = new()
    {
        new Tonality("C Major", "C-E-G", "No accidentals"),
        new Tonality("G Major", "G-B-D", "F♯")
    };

        public IEnumerable<Tonality> GetAllTonalities() => _tonalities;
    }
}
