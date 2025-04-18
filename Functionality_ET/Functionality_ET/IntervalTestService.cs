using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Functionality_ET
{
    public class IntervalTestService
    {
        private readonly IIntervalRepository _intervalRepo;
        private readonly ITestResultRepository _resultRepo;
        private List<Interval> _currentTest;

        public IntervalTestService(
            IIntervalRepository intervalRepo,
            ITestResultRepository resultRepo)
        {
            _intervalRepo = intervalRepo;
            _resultRepo = resultRepo;
        }

        public void GenerateTest(int questions)
        {
            var intervals = _intervalRepo.GetAllIntervals().ToList();
            var rnd = new Random();
            _currentTest = Enumerable.Range(0, questions)
                .Select(_ => intervals[rnd.Next(intervals.Count)]).ToList();
        }

        public bool CheckAnswer(int questionIndex, Interval answer)
        {
            return _currentTest[questionIndex].Semitones == answer.Semitones;
        }

        public Interval GetTestInterval(int index)
        {
            if (index < 0 || index >= _currentTest.Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            return _currentTest[index];
        }

        public void SaveResults(int correctAnswers)
        {
            _resultRepo.AddResult(new TestResult(correctAnswers, _currentTest.Count));
        }
    }
}
