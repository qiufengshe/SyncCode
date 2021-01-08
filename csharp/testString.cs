namespace dotnet_perf
{
    //[MemoryDiagnoser]
    [DisassemblyDiagnoser(printSource: true)]
    public class TestString
    {
        

        [Benchmark]
        public string ToString12345() => 12345.ToString();

        [Benchmark]
        public string ToString1() => 12345 + "";

       
    }
}
