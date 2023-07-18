using System.IO.MemoryMappedFiles;

namespace ConsoleApp2;

public abstract class BusinessRequirement
{
    public virtual void Begin(string msg)
    {
        Console.WriteLine("work days will be monday-friday");
    }

    public virtual void End()
    {
        Console.WriteLine("Completed - base");
    }
}

public class workDays : BusinessRequirement
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

interface WorkHours
{
    void WorkingHours();
}

interface WorkMode
{
    void WorkingMode();
}

public class BusinessProject: WorkHours, WorkMode
{
    public static string officeWorkDays,codingStandard;
    static BusinessProject()
    {
        officeWorkDays="Office working days would be Monday-Friday";
    }

    public BusinessProject(char ch)
    {
        if (ch == 'w')
            officeWorkDays = "Office working days would be Wednesday-Sunday";
        Console.WriteLine(officeWorkDays);
    }

    public BusinessProject()
    {
        codingStandard="Company Uses Camel-Case Coding standard";
        Console.WriteLine(codingStandard);
    }
    
    // public static void Main()
    // {
    //     BusinessProject obj = new BusinessProject('w');
    //     BusinessProject obj1 = new BusinessProject();
    //     BusinessProject obj2 = new BusinessProject('c','s');
    //     BusinessRequirement overrides = new workDays();
    //     obj.WorkingHours();
    //     obj1.WorkingMode();
    // }

    public void WorkingHours()
    {
        Console.WriteLine("Companies Working Hours will be 9 Hours daily");
    }
    
    public void WorkingMode()
    {
        Console.WriteLine("Companies Working mode is work from home");
    }
}

// coding standar
// business requirement
