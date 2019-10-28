using BenchmarkDotNet.Running;

namespace SoapTest.Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<GetRatesQueryBenchmark>();
        }
    }
}
