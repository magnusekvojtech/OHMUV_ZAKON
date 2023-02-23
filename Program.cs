// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vítejte v našem Ohmově zákoně");
Console.WriteLine("Zadejte hodnotu U");
string z_klavesnice = Console.ReadLine();
double U = Convert.ToDouble(z_klavesnice);
Console.WriteLine("Zadejte hodnotu I"); 
string z_klavesnice_2 = Console.ReadLine();
double I = Convert.ToDouble(z_klavesnice_2);
Console.WriteLine("Zadejte hodnotu R");
string z_klavesnice_3 = Console.ReadLine();
double R = Convert.ToDouble(z_klavesnice_);
Console.WriteLine("Vyberte operaci");
Console.WriteLine("1 - napětí");
Console.WriteLine("2 - proud");
Console.WriteLine("3 - odpor");
string vyber = Console.ReadLine();

int menu = Convert.ToInt16(vyber);
double vysledek = 0;
switch (menu)

{
    case 1:
        vysledek = R * I;
        Console.WriteLine(vysledek);
        break;
    case 2:
        vysledek = U / R;
        Console.WriteLine(vysledek);
        break;
    case 3:
        vysledek = U / I;
        Console.WriteLine(vysledek);
        break;
}
