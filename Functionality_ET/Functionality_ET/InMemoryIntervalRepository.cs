using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality_ET
{
    public class InMemoryIntervalRepository : IIntervalRepository
    {
        private readonly List<Interval> _intervals = new()
    {
        new Interval("Perfect Fourth", 5),
        new Interval("Perfect Fifth", 7)
    };

        public IEnumerable<Interval> GetAllIntervals() => _intervals;
    }
}
