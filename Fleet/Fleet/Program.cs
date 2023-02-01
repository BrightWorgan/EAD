// See https://aka.ms/new-console-template for more information
using Fleet.Models;
using Fleet.NewFolder;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

Car Vech1 = new Car("Nissan", "Leaf", "231-D-007", 1200);
Car Vech2 = new Car("Mazda", "Red", "211-C-4044", 1600);
Car Vech3 = new Car("Nissan", "Leaf", "231-D-007", 1600);
Car Vech4 = new Car("Tesla", "S-Series", "231-D-902", 2200);
Car Vech5 = new Car("Mazda", "Red", "221-K-9044", 1600);
Car Vech6 = new Car("Tesla", "S-Series", "212-D-2656", 1200);
Car Vech7 = new Car("Tesla", "S-Series", "222-D-650", 1200);
Car Vech8 = new Car("Nissan", "Leaf", "231-D-007", 1200);
Car Vech9 = new Car("Nissan", "Leaf", "231-D-7090", 1200);
Car Vech10 = new Car("Nissan", "Leaf", "231-D-8722", 1800);

Console.WriteLine(Vech1);

CarContext ctx = new CarContext();

var x = ctx.Database.EnsureCreated();
ctx.Cars.Add(Vech1);
ctx.Cars.Add(Vech2);
ctx.Cars.Add(Vech3);
ctx.Cars.Add(Vech4);
ctx.Cars.Add(Vech5);
ctx.Cars.Add(Vech6);
ctx.Cars.Add(Vech7);  
ctx.Cars.Add(Vech8);
ctx.Cars.Add(Vech9);
ctx.Cars.Add(Vech10); 
    
ctx.SaveChanges();


// Student collection
IList<Car> FleetList = new List<Car>() 
{ 
        new Car("Nissan", "Leaf", "231-D-007", 1200),
        new Car("Mazda", "Red", "211-C-4044", 1600),
        new Car("Nissan", "Leaf", "231-D-007", 1600),
        new Car("Tesla", "S-Series", "231-D-902", 2200),
        new Car("Mazda", "Red", "221-K-9044", 1600),
        new Car("Tesla", "S-Series", "212-D-2656", 1200),
        new Car("Tesla", "S-Series", "222-D-650", 1200),
        new Car("Nissan", "Leaf", "231-D-007", 1200),
        new Car("Mazda", "Blue", "231-D-7090", 1200),
        new Car("Mazda", "Silver", "231-D-8722", 1800)
};

// LINQ Query  to find out Mazda's with EngineSize
var Mazdas = from c in FleetList
                      where c.EngineSize < 1600 && c.Model = "Mazda"
                      select c;