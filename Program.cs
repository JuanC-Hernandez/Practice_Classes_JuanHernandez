namespace Practice_Classes_JuanHernandez
{
    internal class Program
    {
        // Juan Hernandez
        // Practice Assignment: Classes
        // 01/15/24
        static void Main(string[] args)
        {
            Car car1 = new Car(); // new instance of Class
            car1.Make = "Toyota"; // adding information to Make Field
            car1.Model = "Camry"; // adding information to Model Field
            car1.Year = 2019; // adding information to Year Field
            car1.Color = "Red"; // adding information to Color Field
            car1.Mileage = 20000; // adding information to Mileage Field
            Console.WriteLine($"Car Details: {car1.Year} {car1.Color} {car1.Make} {car1.Model}, Mileage: {car1.Mileage}"); // Displaying info

            Bike bike1 = new Bike(); // new instance of Class
            bike1.Brand = "Trek"; // adding information to Brand Field
            bike1.Type = "Mountain"; // adding information to Type Field
            bike1.Color = "red"; // adding information to Color Field
            bike1.Numberofwheels = 2; // adding information to num of wheels Field
            Console.WriteLine($"Bike brand: {bike1.Brand}, Type: {bike1.Type}, Color: {bike1.Color}, {bike1.Numberofwheels} Wheels");

            Team team1 = new Team(); // new instance of Class
            team1.Sport = "Soccer"; // adding information to sport Field
            team1.Teamname = "Club America"; // adding information to name Field
            team1.Datefounded = 1994; // adding information to year Field
            team1.City = "Seattle"; // adding information to city Field
            Console.WriteLine($"Your Team: {team1.City} {team1.Teamname} {team1.Sport} Team, est.{team1.Datefounded}"); // Displaying info
        }
    }
}