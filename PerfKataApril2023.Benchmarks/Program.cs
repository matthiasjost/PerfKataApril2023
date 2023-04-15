using BenchmarkDotNet.Running;

namespace PerfKataApril2023.Benchmarks;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmarks>();
    }
}