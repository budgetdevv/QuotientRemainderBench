using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[DisassemblyDiagnoser(exportDiff: true, exportCombinedDisassemblyReport: true)]
public class Bench
{
    [ModuleInitializer]
    public static void RunCctor()
    {
        RuntimeHelpers.RunClassConstructor(typeof(Bench).TypeHandle);
    }

    static Bench()
    {
        
    }
    
    [Benchmark]
    public void Spicy()
    {
        SpicyImpl(int.MaxValue, out _, out _);
    }
    
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SpicyImpl(int Input, out int Quotient, out int Remainder)
    {
        Remainder = Input % 10;

        Quotient = (Input - Remainder) / 10;
    }
    
    [Benchmark]
    public void TrumpMcD()
    {
        TrumpMcDImpl(int.MaxValue, out _, out _);
    }
    
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void TrumpMcDImpl(int Input, out int Quotient, out int Remainder)
    {
        Quotient = Input / 10;

        Remainder = Input - (Quotient * 10);
    }
}