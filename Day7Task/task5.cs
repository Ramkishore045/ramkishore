using System;
class Task5
{
public static void Main()
{
string[][]Product=new string[3][];
Product[0]=new string[]{"Biscuit","Biscuit","Biscuit","Biscuit"};
Product[1]=new string[]{"Chocolates","Chocolates","Chocolates","Chocolates","Chocolates"};
Product[2]=new string[]{"Drinks","Drinks","Drinks","Drinks","Drinks","Drinks"};
for(int i=0;i<Product.Length;i++)
{
	for(int j=0;j<Product[i].Length;j++)
	Console.Write(Product[i][j]+"\t");
	Console.WriteLine();


}
}
}