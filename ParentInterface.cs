namespace ConsoleApp2;

interface ParentInterfacer
{
    void ParentInterfaceMethod();
}

interface ChildInterfacer: ParentInterfacer
{
    void ChildInterfaceMethod();
}

class ParentInterface :ChildInterfacer
{
    // static void Main()
    // {
    //     ParentInterface obj = new ParentInterface();
    //     obj.ChildInterfaceMethod();
    //     obj.ParentInterfaceMethod();
    // }

    public void ChildInterfaceMethod()
    {
        Console.WriteLine("ChildInterfaceMethod() is implemented");
    }
    
    public void ParentInterfaceMethod()
    {
        Console.WriteLine("ParentInterfaceMethod() is implemented");
    }
}