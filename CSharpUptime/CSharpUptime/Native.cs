using System.Runtime.InteropServices;

namespace CSharpUptime;

public static class Native
{
    [StructLayout(LayoutKind.Sequential)]
    public class Stodi
    {
        public UInt64 boot_time;
        public UInt64 current_time;
    }
    
    // type is really an enum, but we only care about fetching uptime info
    [DllImport("ntdll.dll", CharSet = CharSet.Ansi, SetLastError = false)]
    public static extern int ZwQuerySystemInformation(int type, Stodi stodi, uint bufferSize, uint unused);
}