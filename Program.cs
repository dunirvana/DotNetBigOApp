// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;

Console.WriteLine("Exemplificando BigO!");

// var bigO = new BigO();
// bigO.O1();
// bigO.On();
// bigO.On2();
// bigO.OlogN();
// bigO.OnLogN();

BenchmarkRunner.Run<BenchmarkBigO>();
