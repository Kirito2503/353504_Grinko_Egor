namespace Functionality_ET
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            var tonalityRepo = new InMemoryTonalityRepository();
            var intervalRepo = new InMemoryIntervalRepository();
            var resultRepo = new InMemoryTestResultRepository();


            var quintCircle = new QuintCircleService(tonalityRepo);
            var testService = new IntervalTestService(intervalRepo, resultRepo);
            var statsService = new StatisticsService(resultRepo);

            Console.WriteLine("Quint Circle:");
            foreach (var t in quintCircle.GetTonalities())
            {
                Console.WriteLine($"{t.Name}: {t.Chord} ({t.KeySignature})");
            }


            testService.GenerateTest(2);
            Console.WriteLine("\nInterval Test:");
            int correct = 0;
            for (int i = 0; i< 2; i++)
            {
                Console.WriteLine($"Is this interval {testService.GetTestInterval(i).Name}? (Y/N)");
                correct += Console.ReadLine().ToUpper() == "Y" ? 1 : 0;
            }
            testService.SaveResults(correct);

            Console.WriteLine($"\nSuccess Rate: {statsService.CalculateSuccessRate():P}");

        }
    }
}
