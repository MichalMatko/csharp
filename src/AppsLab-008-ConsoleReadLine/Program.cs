Console.WriteLine("Ako sa voláš?");
string? meno = Console.ReadLine();

Console.WriteLine("Koľko máš rokov?");
string vstup = Console.ReadLine() ?? "0";
int vek = int.Parse(vstup);
Console.WriteLine("Máš " + vek + " rokov." + "\n");

Console.WriteLine("Aké je tvoje obľúbené jedlo?");
string? jedlo = Console.ReadLine();

Console.WriteLine("Ahoj tvoje meno je " + meno + " máš " + vek + " rokov" + " tvoje obľúbené jedlo je " + jedlo );