using System;
class Switch
{
public static void Main()
{
Console.WriteLine("Please select your package:");

Console.WriteLine("Type 1 for Package A:\n\t*South Special\n\t*Children's Club\n\t*Movies");
Console.WriteLine("Type 2 for Package B:\n\t*News\n\t*Sports\n\t*Movies\n\t*Regional-2");
Console.WriteLine("Type 3 for Package C:\n\tDiscovery,History,National");



int n = Convert.ToInt32(Console.ReadLine());
switch(n)
{
case 1:Console.WriteLine("Rate$250");
			break;
case 2:Console.WriteLine("Rate $450");
			break;
case 3:Console.WriteLine("Rate $350");
			break;
default:Console.WriteLine("please select valid package");
			break;


}




}
} 