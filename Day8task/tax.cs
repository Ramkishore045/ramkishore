using System;
class VAT
{
public virtual double Calculatetax(int amt)
{
double vat = (amt*(1.2));
return vat;
}
}
class GST:VAT
{
public override double Calculatetax(int amt)
{
double gst = amt*0.12;
return gst;
}
}
class tax
{
public static void Main()
{
GST tobj = new GST();
double Result = tobj.Calculatetax(300);
Console.WriteLine("The GST is {0}",Result);
VAT tobj1 = new VAT();
double result = tobj1.Calculatetax(200);
Console.WriteLine("The VAT is {0}",result);
}
}