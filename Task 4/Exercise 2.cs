Console.Write("INSERT NUMBER: ");
int num = Convert.ToInt32(Console.ReadLine());
bool positive = (num > 0);    
bool negative = (num < 0);  
if (positive)
{
    
    do
    {

        Console.WriteLine(num);
        num--;

    } while (num >= 0);

}else if(negative)
{

    do
    {

        Console.WriteLine(num);
        num++;

    } while (num <= 0);


}
else
{
    Console.WriteLine("Your input was 0, not positive or negative B)");
}


    
