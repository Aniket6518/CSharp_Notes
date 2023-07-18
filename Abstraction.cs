namespace ConsoleApp2;

public abstract class baseC1
{
    public virtual void Begin(string msg)
    {
        Console.WriteLine("base class :"+msg);
    }

    public virtual void End()
    {
        Console.WriteLine("Completed - base");
    }
}

public class DerivedC : baseC1
{
    public override void Begin(string msg)
    {
        Console.WriteLine("Derived :"+msg);
    }

    public new void End()
    {
        // base.Begin("Calling Base :");
        Console.WriteLine("Completed - Derived");
    }
}

public class TestOverrideShadow
{
    // public static void Main()
    // {
    //     baseC1 overrides = new DerivedC();
    //     DerivedC shadows = new DerivedC();
    //     
    //     overrides.Begin("Begin test ");
    //     overrides.End();
    //     
    //     shadows.Begin("Begin test ");
    //     shadows.End();
    // }
}