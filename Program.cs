// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;

Console.WriteLine("Exemplificando BigO!");

#if DEBUG
  var bigO = new BigO();
  bigO.O1();
  bigO.On();
  bigO.On2();
  bigO.OlogN();
  bigO.OnLogN();
#else
  BenchmarkRunner.Run<BenchmarkBigO>();
#endif