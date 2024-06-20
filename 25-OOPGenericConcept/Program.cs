using _25_OOPGenericConcept;

GenericClass<int> genericClass = new GenericClass<int>();
genericClass.Name = "Huseyin";
genericClass.Surname = "Talo";
genericClass.ID = 01; //at the moment of creation (taking instance) of this object if i want to be able to select from different types, i need a generic type.

GenericClass<string> genericClass1 = new GenericClass<string>();
genericClass1.Name = "Husam";
genericClass1.Surname = "Talus";
genericClass1.ID = "2490";

//A generic class is useful for reusable code writing. i can use it again and again.
//A generic class can be a base class for other generic and non generic classes. it can be defined as abstract.
//A generic class can inherit from generic or non generic interfaces, classes

GenericMethod<string> teams = new GenericMethod<string>();
teams.AddInfo(0, "Fenerbahce");
teams.AddInfo(1, "Galatasaray");
teams.AddInfo(2, "Besiktas");
teams.AddInfo(3, "Osmancikspor");
teams.AddInfo(4, "Altınordu");

foreach (var team in teams._array)
{
    Console.WriteLine(team);
}

GenericMethod<int> genericMethodNumbers = new GenericMethod<int>();
Random rand = new Random();
genericMethodNumbers.AddInfo(0, rand.Next(0,100));
genericMethodNumbers.AddInfo(1, rand.Next(0,100));
genericMethodNumbers.AddInfo(2, rand.Next(0,100));

foreach(var numbs in genericMethodNumbers._array)
    Console.WriteLine(numbs);

for (int i = 0; i < teams._array.Length; i++)
{
    Console.WriteLine("Team ID: " + i + " Team name: " + teams.GetInfo(i));
}

NonGenericClass nonGenericClass = new NonGenericClass(); //this is a non generic class meaning we didn't define a T type data while defining it.
nonGenericClass.PrintToScreen(2); //however this is a generic method. defined with a placeholder called T type which materializes when using it on here during runtime.
nonGenericClass.PrintToScreen("Husam");
nonGenericClass.PrintToScreen(true);
nonGenericClass.PrintToScreen<bool>(false);//this is redundant but legal.

//generic is safe type-wise, reduces the probability of encountering a runtime error due to type differences.
//makes typecasting redundant and increases performance.

//TODO: research generic interfaces and generic constraints.

KeyValueDuo<int, string> cities0 = new KeyValueDuo<int, string>();
cities0.ID = 01;
cities0.Name = "Adana";
KeyValueDuo<int, string> cities1 = new KeyValueDuo<int, string>()
{
    ID = 02,
    Name = "Adiyaman"
};

KeyValueDuo<Guid, string> cities2 = new KeyValueDuo<Guid, string>();
cities2.ID = Guid.NewGuid();
cities2.Name = "Istanbul";

Console.WriteLine(cities2.ID + " " + cities2.Name);

List<KeyValueDuo<int, string>> cityList = new List<KeyValueDuo<int, string>>();

cityList.Add(cities0);
cityList.Add(cities1);

foreach (var item in cityList)
    Console.WriteLine(item.ID + " " + item.Name); //remember to access the proper property.
