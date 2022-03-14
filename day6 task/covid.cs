using System;
class Covid
{
public static void Main()
{
string ans;
Console.WriteLine("Covid Checker");
Console.WriteLine("Do You Have Travel History?");
ans=Console.ReadLine();
if(ans=="Yes")
{
Console.WriteLine("Do You Have Temperature?");
ans=Console.ReadLine();
if(ans=="Yes")
{
Console.WriteLine("Do You Have Cough/Snee?");
ans=Console.ReadLine();
if(ans=="Yes")
{
Console.WriteLine(" Please take a Swab Test");
}
else
{
if(ans=="No")
{
Console.WriteLine("Quarantine,Fever Medicine");
}
}
}
else
{
if(ans=="No")
{
Console.WriteLine("Home Quarantine for 28 Days");
}
}
}
else
{
if(ans=="No")
{
Console.WriteLine("Safe not COVID-19");
} 
}
}
}