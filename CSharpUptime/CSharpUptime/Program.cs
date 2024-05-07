using System.Data;

namespace CSharpUptime;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("...... :-)");
        var stodi = new Native.Stodi();
        Native.ZwQuerySystemInformation(3, stodi, 16, 0);
        Console.WriteLine(stodi.boot_time);
        Console.WriteLine(stodi.current_time);
        
        var uptime = (stodi.current_time - stodi.boot_time) / 10000000;
        Console.Write("Days ");
        var days = uptime / 86400;
        Console.WriteLine(days);
        Console.Write("Hours ");
        var hours = (uptime - days * 86400) / 3600;
        Console.WriteLine(hours);
        Console.Write("Minutes ");
        var mins = (uptime - days * 86400 - hours * 3600) / 60;
        Console.WriteLine(mins);
    }
}