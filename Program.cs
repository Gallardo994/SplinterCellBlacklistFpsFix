using System.Diagnostics;

var processListFile = "processlist.txt";
if (!File.Exists(processListFile))
{
    Console.WriteLine("processlist.txt not found, press any key to exit");
    Console.ReadKey();
}

var processList = File.ReadAllLines(processListFile);

foreach (var processName in processList)
{
    Console.WriteLine($"Process: {processName}");
}

var processListHash = new HashSet<string>(processList);

while (true)
{
    var processes = Process.GetProcesses();
    
    foreach (var process in processes)
    {
        if (!processListHash.Contains(process.ProcessName))
        {
            continue;
        }
        
        try
        {
            process.ProcessorAffinity = (IntPtr) 0xFFFFFFFF;
        }
        catch (Exception e)
        {
            // ignored
        }
    }
    
    Thread.Sleep(25);
}