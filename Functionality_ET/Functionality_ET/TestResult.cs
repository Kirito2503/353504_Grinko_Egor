using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionality_ET
{
    public class TestResult
    {
        public DateTime Date { get; }
        public int CorrectAnswers { get; }
        public int TotalQuestions { get; }

        public TestResult(int correct, int total)
        {
            Date = DateTime.Now;
            CorrectAnswers = correct;
            TotalQuestions = total;
        }
    }
}
