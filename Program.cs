using System;

public abstract class BaseC
{
    public void Method1(string msg)
    {
        Console.WriteLine(msg);
    }

    public abstract void MethodAbs();

    public virtual void MethodImp1(string msg)
    {
        Console.WriteLine("From base class :" + msg);
    }
}

public class TestDerived : BaseC
{
    // public static void Main()
    // {
    //     TestDerived obj1 = new TestDerived();
    //     obj1.Method1("message 1");
    //     obj1.MethodAbs();
    //     obj1.MethodImp1("this is overriding");
    //     obj1.MethodImp1();
    // }

    public override void MethodAbs()
    {
        Console.WriteLine("implementing abstract method");
    }

    // public override void MethodImp1(string msg)
    // {
    //     Console.WriteLine("From Child Class :"+msg);
    // }
    
    public void MethodImp1()
    {
        Console.WriteLine("From Child Class without parameter");
    }
}
// class CSharpdate
// {
    // enum Days
    // {
    //     Monday,
    //     Tuesday,
    //     Wednesday,
    //     Thursday,
    //     Friday,
    //     Saturday,
    //     Sunday
    //     
    // }
    
    // public enum shapes
    // {
    //     circle,
    //     square,
    //     rectangle    
    // }
    
    
    // public void peri(int val, shapes s1)
    // {
    //     if (s1 == 0)
    //     {
    //         Console.WriteLine("circumference of circle is :"+(2*3.14*val));
    //     }else if ((int)s1 == 1)
    //     {
    //         Console.WriteLine("circumference of square is :"+(4*val));
    //     }
    //     else
    //     {
    //         Console.WriteLine("circumference of rectangle is :"+(4*val));
    //     }
    //     
    //     Console.WriteLine(s1.GetType());
    // }
    //
    // static void Main()
    // {
        // DateTime today;
        // today = DateTime.Now;
        // Console.WriteLine(today);
        // Console.WriteLine(today.ToShortDateString());
        // Console.WriteLine(today.ToShortTimeString());

        // float n1 = (float)1 / 3;
        // double n2 = (double)1 / 3;
        //
        // if (n1 == n2)
        // {
        //     Console.WriteLine("this is equal :"+n1+" "+n2);
        // }else
        // {
        //     Console.WriteLine("this is not equal :"+n1+" "+n2);
        // }


        // DateTime today;
        // today = DateTime.Now;
        // TimeSpan span1 = TimeSpan.FromDays(today.Day);
        // TimeSpan span2 = TimeSpan.FromHours(today.Hour);
        // TimeSpan span3 = TimeSpan.FromMinutes(today.Minute);
        // TimeSpan span4 = TimeSpan.FromSeconds(today.Second);
        // TimeSpan span5 = TimeSpan.FromMilliseconds(today.Millisecond);
        //
        // Console.WriteLine(span1);
        // Console.WriteLine(span2);
        // Console.WriteLine(span3);
        // Console.WriteLine(span4);
        // Console.WriteLine(span5);
        //
        // TimeSpan span = new TimeSpan(1, 2, 0, 30, 0);
        // Console.WriteLine("span {0}",span);


        // Days day = Days.Monday;
        //
        // if (day == Days.Monday)
        // {
        //     Console.WriteLine("it's Monday");
        // }
        // Console.WriteLine(day);


        // CSharpdate a1 = new CSharpdate();
        // a1.peri(4, shapes.circle);
        // a1.peri(5, shapes.square);
        // a1.peri(6, shapes.rectangle);
        // Console.WriteLine(shapes.circle.GetType());
        
        
        
//     }
//
// }