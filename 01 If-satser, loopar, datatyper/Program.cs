
// if (6  >= 3)
// {
//     Console.WriteLine("Hello, World!");
// }


// Console.WriteLine("Skriv in ditt användarnamn.");
// string username = Console.ReadLine();

// Console.Write("Skriv in lösenord ");
// string password = Console.ReadLine();

// if (username == "kalleanka" && password == "12345")
// {
//     Console.WriteLine("Welcome!");
// }
// else
// {
//     Console.WriteLine("Wrong username or password");
// }

Random random = new Random ();

int rättNummer = random.Next(1, 50); 

int guess = 0;

Console.WriteLine("gissa ett tal mellan 1 och 50.");

while (guess != targetNumber)
{
    Console.Write("skriv in gissning.");
    string input = Console.ReadLine();

    if (int.TryParse(input, out guess))
        {
            if (guess > targetNumber)
            {
                Console.WriteLine("mindre");
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("högre");
            }
            else
            {
                Console.WriteLine("rätt tal");
            }
        }
    else
        {
            Console.WriteLine("fel. skriv in heltal");
        }
}