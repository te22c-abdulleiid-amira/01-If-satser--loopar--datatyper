
if (6  >= 3)
{
    Console.WriteLine("Hello, World!");
}


Console.WriteLine("Skriv in ditt användarnamn.");
string username = Console.ReadLine();

Console.Write("Skriv in lösenord ");
string password = Console.ReadLine();

if (username == "kalleanka" && password == "12345")
    {
        Console.WriteLine("Welcome!");
    }
else
    {
        Console.WriteLine("Wrong username or password");
    }

for (int i = 0; i < 32; i++)
{
    Console.WriteLine("Hello, World");
}



while (password != "12345")
{
    Console.Write("Enter password: ");
    password = Console.ReadLine();

    if (password != "12345")
    {
        Console.WriteLine("Wrong password, try again.");
    }
}
Console.WriteLine("Access granted!");

for (int i = 0; i < 5; i++)
{
    Console.Write("Enter a number: ");
    int number = int.Parse(Console.ReadLine());

    if (number > 5)
    {
        Console.WriteLine("högre än 5!");
    }
}
