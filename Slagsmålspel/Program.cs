using System.Reflection.Metadata.Ecma335;

Random generator = new Random();

string Winner = "Nobody";
int Player1 = 100;
int Player2 = 100;
int Player1Attack = 0;
int Player2Attack = 0;
string play = "yes";



    Console.WriteLine("Välkommen till vevet");
    Console.WriteLine("Skriv ditt namn: ");
    string Name = Console.ReadLine();
    Console.WriteLine($"Välkommen {Name}");
    Console.WriteLine("Vem vill du slåss mot?");
    string Fiende = Console.ReadLine();
    Console.ReadLine();
    Console.WriteLine("Tryck på valfri knapp för att starta vevet!");
    Console.ReadKey();
    Console.WriteLine($"{Name}'s hp är {Player1} och {Fiende}'s hp är {Player2}.");
    Console.WriteLine("--------------------------------------------------------");

    while (Player1 > 0 && Player2 > 0)
    {
        Player1Attack = generator.Next(20);
        Player2Attack = generator.Next(20);
        Player1 = Player1 - Player2Attack;
        Player2 = Player2 - Player1Attack;
        Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
        Console.ReadKey();
        Console.WriteLine($"{Name}'s hp är {Player1} och {Fiende}'s hp är {Player2}.");
        Console.WriteLine("--------------------------------------------------------");
    }   

        if (Player1 <= 0)
        {
            Winner = Fiende;
            Console.WriteLine($"Vinnaren är {Winner}!");
            Console.WriteLine("Would you like to play again(Yes or no)?: ");
            play = Console.ReadLine();
            play.ToLower();
        }   
        else if (Player2 <= 0)
        {
            Winner = Name;
            Console.WriteLine($"Vinnaren är {Winner}!");
            Console.WriteLine("Vill du spela igen (Ja/Nej)?: ");
            play = Console.ReadLine();
            play.ToLower();
        }     

    Console.ReadLine();


