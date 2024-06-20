using _19_EnumOOP;

Console.WriteLine("Enter the number, get the month: ");
byte.TryParse(Console.ReadLine(), out byte monthNumber);
string selectedMonth = Enum.GetName<Months>((Months)monthNumber);
Console.WriteLine(monthNumber + ". Month is " + selectedMonth);

foreach (var item in Enum.GetValues<Months>())
{
    Console.WriteLine((int)item + ". Month is " + item); //you can typecast to access the value or its enum number.
}