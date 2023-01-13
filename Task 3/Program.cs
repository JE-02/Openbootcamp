
Console.WriteLine("Input your data: ");
Console.WriteLine("Name: ");
string name = Console.ReadLine();

Console.WriteLine("Last Name: ");
string lastName = Console.ReadLine();

Console.WriteLine("Phone Number: ");
string phoneNumber = Console.ReadLine();

Console.WriteLine("Adress: ");
string adress = Console.ReadLine();

Console.WriteLine("Email: ");
string email = Console.ReadLine();

Console.WriteLine("Are you a new client: Y/N ");
char newClient = Convert.ToChar(Console.ReadLine());
bool isNew = (newClient == 'Y') ? true : (newClient == 'Z') ? false : false;


User Data = new User(name, lastName, phoneNumber, adress, email, isNew);
Console.WriteLine(Data);
public struct User
{
    public User(string name, string lastName, string adress, string phoneNumber, string email, bool isNew)
    {
        NAME = name;
        LAST_NAME = lastName;
        PHONE_NUMBER = phoneNumber;
        IS_NEW = (isNew) ? "New client, Welcome!" : "Nice to see you again!";
        ADRESS = adress;
        EMAIL = email;
    }

    public string NAME{ get; }
    public string  LAST_NAME { get; }
    public string PHONE_NUMBER { get; } 
    public string IS_NEW { get; }
    public string ADRESS { get; }
    public string EMAIL { get; }

    public override string ToString() => $"-------- DATA -------- \n {IS_NEW}\n Full name: {NAME} {LAST_NAME}\n Phone Number: {PHONE_NUMBER}\n Adress: {ADRESS}\n Email: {EMAIL} ";

}





