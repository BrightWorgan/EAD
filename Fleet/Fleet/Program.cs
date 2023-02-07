// See https://aka.ms/new-console-template for more information
using Fleet.Models;
using Fleet.NewFolder;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

Car Vech1 = new Car("Nissan", "Leaf", "231-D-007", 1200);
Car Vech2 = new Car("Mazda", "Red", "211-C-4044", 1600);
Car Vech3 = new Car("Nissan", "Leaf", "231-D-8707", 1600);
Car Vech4 = new Car("Tesla", "S-Series", "231-D-902", 2200);
Car Vech5 = new Car("Mazda", "Red", "221-K-9044", 1600);
Car Vech6 = new Car("Tesla", "S-Series", "212-D-2656", 1200);
Car Vech7 = new Car("Tesla", "S-Series", "222-D-650", 1200);
Car Vech8 = new Car("Nissan", "Leaf", "231-D-777", 1200);
Car Vech9 = new Car("Nissan", "Leaf", "231-D-7090", 1200);
Car Vech10 = new Car("Nissan", "Leaf", "231-D-8722", 1800);




// connect to local database
var context = new CarContext();
context.Database.EnsureCreated();


// function to add a Car to the loacl database if it is not already there
var addCar = (Car c) => {
      var result = context.Cars.Find(c.Registration);
    if (result == null) {
        context.Cars.Add(c);
    }
    else
    {
        Console.WriteLine(c.Registration + " That Registration Already Exists... Skipping...");
    }
};

addCar(Vech1);
addCar(Vech2);
addCar(Vech3);
addCar(Vech4);
addCar(Vech5);
addCar(Vech6);
addCar(Vech7);
addCar(Vech8);
addCar(Vech9);
addCar(Vech10);

context.SaveChanges();

// List all cars in ascending registration order
var AscOrder = from c in context.Cars
               orderby c.Registration
               select c;
foreach (Car c in AscOrder)
{
    Console.WriteLine(c);
}
Console.WriteLine("\n\tTask 1 A Complete");


// List the models for all Mazda cars in the fleet
var Mazdas = from c in context.Cars
    where c.Model == "Mazda"
    select c;
foreach (Car c in Mazdas)
{
    Console.WriteLine(c);
}
Console.WriteLine("\n\tTask 1 B Complete");


// List all cars in descending engine size order
var DescOrder = from c in context.Cars
                orderby c.EngineSize descending
                select c;
foreach (Car c in DescOrder)
{
    Console.WriteLine(c); 
}
Console.WriteLine("\n\tTask 1 C Complete");


// List just the make and model for cars whose engine size is 1600 cc
var MakenModel = from c in context.Cars
                 where c.EngineSize == 1600
                 select c.Make + "//"+ c.Model;



// Count the number of cars whose engine size is 1600 cc or less
var CountingSmallCars = (from c in context.Cars
                        where c.EngineSize <= 1600
                         select c).Count();




Console.WriteLine("\n\tTask 1 Complete");
Console.ReadLine();