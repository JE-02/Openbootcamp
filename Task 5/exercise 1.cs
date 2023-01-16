Console.WriteLine("PRODUCT --> PC $15000");
Console.Write("NAME: ");
string name = Console.ReadLine();
Console.Write("EMAIL: ");
string email = Console.ReadLine();
Console.Write("DO YOU HAVE A CUPON Y/N: ");
char doHaveCupon = Convert.ToChar(Console.ReadLine());
bool cupon = (doHaveCupon == 'Y') ? true : (doHaveCupon == 'N') ? false : false;

if (cupon)
{
    Console.Write("WHAT TYPE OF CUPON (10/20/30): ");
    int cuponAmount = Convert.ToInt32(Console.ReadLine());

    switch (cuponAmount)
    {
        case 10:
            Console.WriteLine($"PRICE WITH 10% DISCOUNT: {15000 - (15000 * 0.1)} ");
            break;
        case 20:
            Console.WriteLine($"PRICE WITH 20% DISCOUNT: {15000 - (15000 * 0.2)} ");
            break;
        case 30:
            Console.WriteLine($"PRICE WITH 10% DISCOUNT: {15000 - (15000 * 0.3)} ");
            break;
        default:
            break;
    }
}
else
{
    Console.WriteLine("PRICE: 15000");
}



