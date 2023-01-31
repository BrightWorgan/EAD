// See https://aka.ms/new-console-template for more information
using Fleet.Models;
using Fleet.NewFolder;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

Car Vech1 = new Car("Nissan", "Leaf", "231-D-007", 1200);
Console.WriteLine(Vech1);

CarContext ctx = new CarContext();

var x = ctx.Database.EnsureCreated();
ctx.Cars.Add(Vech1);
ctx.SaveChanges();