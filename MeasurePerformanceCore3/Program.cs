using BenchmarkDotNet.Running;

namespace MeasurePerformanceCore3
{
    // For reference: https://github.com/stevejgordon/BenchmarkAndSpanExample/tree/Benchmarks
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<NameParserBenchmarks>();
        }
    }
}
