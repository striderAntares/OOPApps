namespace _17_HotelStructOOP
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            hotel.HotelID = 01;
            hotel.HotelName = "Azimut";
            Console.WriteLine(hotel.HotelID + " " + hotel.HotelName);
        }
    }
struct Hotel
{
    public int HotelID { get; set; }
    public string HotelName { get; set; }
}
}