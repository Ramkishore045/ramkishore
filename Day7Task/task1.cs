using System;
class Task1

{
public static void Main()
{
string Name;
int Age;
Console.WriteLine("Enter Name of the Person:-");
Name=Console.ReadLine();

Console.WriteLine("Enter Age of the Person:-");
Age=Convert.ToInt32(Console.ReadLine());
int i=0;
while(i<Age){

Console.WriteLine(Name);
i++;

}


}
}