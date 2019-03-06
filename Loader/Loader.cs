using System.Diagnostics;
using System.Runtime.InteropServices;

public class TestClass
{
    public TestClass()
    {
        
    }

    public static string RunProcess(string path)
    {
        Process.Start("calc.exe");
        return "boom!";
    }
}
