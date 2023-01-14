

Console.Write("INSERT WIDTH: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("INSERT HEIGTH: ");
int heigth = Convert.ToInt32(Console.ReadLine());
Console.Write("FULL? Y/N:  ");
bool full = (Convert.ToChar(Console.ReadLine()) == 'Y') ? true : false;

bool firstRow = true;
bool lastRow = false;

if (!full)
{

    for (int i = 1; i < heigth; i++)
    {

        if (i == heigth - 1) lastRow = true;

        if (firstRow || lastRow)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write("^");
            }
            Console.WriteLine();
        }


        firstRow = false;

        if (!firstRow && !lastRow)
        {
            bool x = true;
            Console.Write("^");
            x = false;

            if (!x)
            {
                for (int k = 0; k < width - 2; k++)
                {
                    Console.Write(" ");
                }
            }

            Console.Write("^");

            Console.WriteLine();

        }
    }
}
else
{
    for (int i = 0; i < heigth; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write("^");
        }
        Console.WriteLine();
    }
}
