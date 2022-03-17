using System;
interface membership
{
void Silver();
void Gold();
void Platinum();
}
class team:membership
{
public void Silver()
{
Console.WriteLine("Silver");
Console.WriteLine("3 days accomodation at resort");
}
public void Gold()
{
Console.WriteLine("gold");
Console.WriteLine("5 days accomadation at resort and 2 dinners on the house");
}
public void Platinum()
{
Console.WriteLine("Platinum");
Console.WriteLine("7 days accomadation at resort and  5 dinners on the house");
}
}
class Id
{
public static void Main()
{
team obj=new team();
obj.Silver();
obj.Gold();
obj.Platinum();
}
}