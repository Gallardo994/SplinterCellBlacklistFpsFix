using System.Diagnostics;

while (true)
{
    var processes = Process.GetProcessesByName("Blacklist_DX11_game");
    
    foreach (var process in processes)
    {
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