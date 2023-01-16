string[] languagesList = { "C", "Javascript", "C#", "Python", "Pascal" };
Console.WriteLine("Elige un lenguaje de programacion 1-C 2-Javascript 3-C# 4-Python 5-Pascal");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        break;
        Console.WriteLine(languagesList[0]);

    case 2:
        Console.WriteLine(languagesList[1]);
        break;

    case 3:
        Console.WriteLine(languagesList[2]);
        break;

    case 4:
        Console.WriteLine(languagesList[3]);
        break;

    case 5:
        Console.WriteLine(languagesList[4]);
        break;

    default:
        Console.WriteLine("THAT OPTION DOESNT EXIST!");
        break;
}