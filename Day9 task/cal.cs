using System;
abstract class Calculator
{
public abstract void cal(int x, int y);

}
class Add:Calculator
{
public  override void cal(int x, int y)
{
Console.WriteLine("Sum\t" +(x+y));
}
}
class Sub:Calculator
{
public override void cal(int x, int y)
{
Console.WriteLine("Diff\t" +(x-y));
}
}
class Mul:Calculator
{
public override void cal(int x, int y)
{
Console.WriteLine("Prod\t" +(x*y));
}
}
class Div:Calculator
{
public override void cal(int x,int y)
{
 double m= (double)x/y;
Console.WriteLine("Rem\t" +m);
}
}
class main
{
public static void Main()
{
Add obj =new Add();
obj.cal(12,13);
Sub obj1 =new Sub();
obj1.cal(12,20);
Mul obj2 =new Mul();
obj2.cal(13,25);
Div obj3 =new Div();
obj3.cal(12,544);
}
}