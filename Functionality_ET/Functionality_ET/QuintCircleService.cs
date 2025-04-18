using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality_ET
{
    public class QuintCircleService
    {
        private readonly ITonalityRepository _repository;

        public QuintCircleService(ITonalityRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Tonality> GetTonalities() => _repository.GetAllTonalities();
    }
}

