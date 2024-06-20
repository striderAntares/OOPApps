using _01_OOPDefiningClass;

Iron iron1 = new Iron(); // this creates a new object from the Iron class and catches it in iron1 a variable of type Iron. taking instance.
iron1.HasBoiler = true;
iron1.Brand = "Rowenta";
iron1.Colour = "Red";
iron1.Temperature = 0;

Console.WriteLine($"Iron object has been created with following information:\n Brand: {iron1.Brand}\n Colour: {iron1.Colour}\n Temperature: {iron1.Temperature}\n Has Boiler: {(iron1.HasBoiler ? "Yes" : "No")}");

Iron iron2 = new Iron("Bosch","Aqua",false,0);
Iron iron4 = new Iron("Beko", "Black", true, 30);
