//userAgeValidation

// rakendus küsib kasutajalt tema vanust
// kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
// "Sa oled liiga noor, et kasutada Instagrammi."
// Muul juhul
// Konsoolis kuvatakse "Tere tulemast Instagrammi!"

Console.WriteLine("Sisesta oma vanus:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

if (userAge >= 13)
{
    Console.WriteLine("Tere tulemast Instagrammi!");
}
else //if (userAge<13)
{
    Console.WriteLine("Sa oled liiga noor, et kasutada Instagrammi.");
}
