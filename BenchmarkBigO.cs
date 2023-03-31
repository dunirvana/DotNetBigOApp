using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[MemoryDiagnoser]
public class BenchmarkBigO
{
  private BigO bigO = new BigO();

  [Benchmark]
  public void O1()
  {
    bigO.O1();
  }

  [Benchmark]
  public void On()
  {
    bigO.On();
  }

  [Benchmark] 
  public void On2()
  {
    bigO.On2();
  }

  [Benchmark]
  public void OlogN()
  {
    bigO.OlogN();
  }

  [Benchmark]
  public void OnLogN()
  {
    bigO.OnLogN();
  }
  
}