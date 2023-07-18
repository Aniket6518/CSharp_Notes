namespace ConsoleApp2;

public class Attributes
{
    public void method(int num)
    {
        if (num % 2 == 1)
            Console.WriteLine("given number is odd");
        else
            Console.WriteLine("given number is even");
    }
    
    public void method(int num1,int num2)
    {
        if(num1==num2)
            Console.WriteLine("these numbers are equal");
        else if (num1 > num2)
            Console.WriteLine(num1 + " is greater then " + num2);
        else
            Console.WriteLine(num2 + " is greater then " + num1);
    }
    
    public void method(int num1,int num2,char op)
    {
        if(op=='a')
            Console.WriteLine("sum of the given numbers is :"+(num1+num2));
        else if(op=='s')
            Console.WriteLine("subtraction of the given numbers is :"+(num1-num2));
        else if(op=='d')
            Console.WriteLine("division of the given numbers is :"+(num1/num2));
        else if (op == 'm')
            Console.WriteLine("multiplication of the given numbers is :" + (num1 * num2));
        else
            Console.WriteLine("enter a valid operation!!!");
    }
    
    public void method(string msg)
    {
        Console.WriteLine(msg+" mconverted to upeercase :" + msg.ToUpper());
    }
    
    public void method(string msg,int val)
    {
        Console.WriteLine(msg+" department has "+val+" budget");
    }
    
    public void method(int val,string msg)
    {
        Console.WriteLine(msg+" department has code ID :"+val);
    }
    
    // public static void Main()
    // {
    //     Attributes obj=new Attributes();
    //     obj.method(12);
    //     obj.method(12,18);
    //     obj.method(12,6,'d');
    //     obj.method("Aniket");
    //     obj.method("computer",10000);
    //     obj.method(3,"IT");
    // }
}  