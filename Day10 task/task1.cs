using System;
class Name
{ 
	int age;
	public Name(int age)
	{
		this.age=age;
		Console.WriteLine("The Age is "+age);

	}
	string name;
	public Name(string name)
	{
		this.name=name;
		Console.WriteLine("The Name is "+name);
	}
	
public static void Main()
{
   Name obj=new Name("Ramkishore");
   Name obj2=new Name("21");

	}
}