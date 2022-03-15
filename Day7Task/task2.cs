using System;
class Task2

{
public static void Main()
{
int n,num;
Console.WriteLine("Enter the Number:");
num=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Multipicand:");
n=Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=n;i++){
Console.WriteLine("{0}*{1}={2}",num,i,num*i);
}

}
}