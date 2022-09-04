``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22000
Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=8.0.100-alpha.1.22452.5
  [Host]     : .NET 7.0.0 (7.0.22.42212), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.42212), X64 RyuJIT


```
|   Method |      Mean |     Error |    StdDev | Code Size |
|--------- |----------:|----------:|----------:|----------:|
| TrumpMcD | 0.9144 ns | 0.0002 ns | 0.0002 ns |      82 B |
|    Spicy | 1.4304 ns | 0.0002 ns | 0.0002 ns |     105 B |
