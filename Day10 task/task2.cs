using System;
class Empdetails
{
public void Detail()
{
Console.WriteLine("Employee id");
string empid=Console.ReadLine();
Console.WriteLine("Name");
string name=Console.ReadLine();
Console.WriteLine("Age");
string age=Console.ReadLine();
Console.WriteLine("Years of experience");
string yoe=Console.ReadLine();
Console.WriteLine(empid);
Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(yoe);
}
}
class Salary:Empdetails
{
public void calculationA()	
{
	int s1;
s1=10000+2000;
Console.WriteLine(s1);

}
public void calculationB()	
{
	int s2;
s2=10000+1000;
Console.WriteLine(s2);
}
}
class inherit1
{
public static void Main()
{
Salary good=new Salary();

good.Detail();

Salary good2=new Salary();
Console.WriteLine("department");
string dep=Console.ReadLine();
Console.WriteLine(dep);
switch(dep)
{
	case "Sales" : good2.calculationA();
	break;
	case "Production" : good2.calculationB();
	break;
	
} 

}
}