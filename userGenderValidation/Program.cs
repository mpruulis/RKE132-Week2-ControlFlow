//userGenderValidation

// See https://aka.ms/new-console-template for more information

// rakendusküsib kasutajalt tema sugu
// rakendus küsib kasutajal sisestada tema perekonnanime
// lähtudes kasutaja valikust, rakendus tervitab kasutajat järgnevalt:
// "Tere, härra [kasutaja perekonnanimi]" / "Tere, Proua [kasutaja perekonnanimi]"

Console.WriteLine("Palun sisesta oma sugu (M/N):");
char userGender = Char.Parse(Console.ReadLine()); //Loeb konsoolist maha andmed string formaadis

Console.WriteLine("Sisesta oma perekonnanimi: ");
string userLastName = Console.ReadLine();

if (userGender == 'M')
{
    Console.WriteLine($"Tere, härra {userLastName}!");
}
else if (userGender == 'N')
{
    Console.WriteLine($"Tere, proua {userLastName}!");
}
else
{
    Console.WriteLine($"Tere {userLastName}!");
}