// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        string status = "Healthy";

        Console.WriteLine($"Start: {status}");
        SetHealth(ref status, false);
        Console.WriteLine($"End: {status}");

        // Getting the memory address (for debugging purposes)
        GCHandle handle = GCHandle.Alloc(status, GCHandleType.Pinned);
        IntPtr address = handle.AddrOfPinnedObject();
        Console.WriteLine($"Memory Address: {address}");
        handle.Free();
    }

    static void SetHealth(ref string status, bool isHealthy)
    {
        status = isHealthy ? "Healthy" : "Unhealthy";
        Console.WriteLine($"Middle: {status}");
    }
}
