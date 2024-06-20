using _03_OOPLiveExcercise;

Iron iron1 = new Iron()
{
    Brand = "Tefal",
    Colour = "Black",
    Temperature = 0


};
Console.WriteLine("Brand: " + iron1.Brand + "\n" + "Colour: " + iron1.Colour + "\n" + "Temperature: " + iron1.Temperature);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Increasing temperature by 11");
    iron1.IncreaseTemperature(11);
    Console.WriteLine("Current temperature: " + iron1.Temperature);
}

