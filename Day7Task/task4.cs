using System;
class task4
{
public static void Main()
{
int [] marks=new int[]{80,87,72,68,99};
int x,sum=0;
for(int i=0;i<5;i++)
{
sum= sum+marks[i];
}
x=sum/5;
Console.WriteLine("The average of 5 subs is "+ x);

}
}