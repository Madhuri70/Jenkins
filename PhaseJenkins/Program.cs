// See https://aka.ms/new-console-template for more information
using System.Security;
using PhaseJenkins;


    Console.WriteLine("Joe's Pizza detals!!");
PizzaManagement pm = new PizzaManagement();
foreach (var p in pm.AllPizzas())
{
    Console.WriteLine("Id:" + p.Id);
    Console.WriteLine("Name:" + p.Name);
    Console.WriteLine("Price:" + p.Price);
}
