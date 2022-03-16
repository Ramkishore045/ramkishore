using System;
class addsub1
{
public void addsub(int a,int b){
int sum= a+b;
int diff=a-b;
Console.WriteLine("the sum is\t"+  sum +"\tand the diff is\t"+ diff);
}
}
class muldiv1:addsub1{

public void muldiv(int a,int b){
int prod= a*b;
int rem=a/b;
Console.WriteLine("the product is\t"+ prod +"\tand the remainder is"+ rem);
}
}
class task1{

public static void Main(){
muldiv1 obj= new muldiv1();
obj.muldiv(98,12);
obj.addsub(45,55);
}
}

