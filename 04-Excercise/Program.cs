using _04_Excercise;

Iron iron1 = new Iron()
{
    Brand = Console.ReadLine(),
    Colour = Console.ReadLine(),
    Temperature = 0
    
};

Console.WriteLine("Brand: " + iron1.Brand + " Colour: " + iron1.Colour + " Temperature: " + iron1.Temperature);