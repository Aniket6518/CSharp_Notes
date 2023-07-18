namespace ConsoleApp2;

public class StaticMethod
{
    static int var1 = 0;
    
    public StaticMethod()
    {
        Console.WriteLine(var1);
    }

    public StaticMethod(int n)
    {
        while(var1<1000)
            var1 += n;
        Console.WriteLine(var1);
    }
    
    static StaticMethod()
    {
        var1 = 23;
    }
    // public static void Main()
    // {
    //     StaticMethod obj1 = new StaticMethod();
    //     Console.WriteLine("done 1");
    //     
    //     DateTime day=DateTime.Now;
    //     int val = day.Microsecond;
    //     val += day.Millisecond*1000;
    //     StaticMethod obj = new StaticMethod(20);
    //     DateTime today=DateTime.Now;
    //     int val1 = today.Microsecond;
    //     val1 += today.Millisecond*1000;
    //     Console.WriteLine("time taken (microsecond):"+(val1-val)+" "+val1+" "+val);
    // }
}