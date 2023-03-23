using Factory;
using Factory.Subscriptions;

Console.WriteLine("Hello, World!");

Provider p = new Provider();
p.SelectPlan();

p.GetCurrentPlan();

Console.ReadKey();