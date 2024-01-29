using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Text;

namespace Medium1
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class BenchMarks
    {
        private string str1 = "Hello ";
        private string str2 = "World";

        [Benchmark]
        public string ConcatWithPlus()
        {
            return str1 + str2;
        }

        [Benchmark]
        public string ConcatWithStringBuilder()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append(str1);
            stringBuilder.Append(str2);
            return stringBuilder.ToString();
        }
    }
}
