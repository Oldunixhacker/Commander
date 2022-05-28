using System.Diagnostics;
Console.WriteLine("Welcome to Windows Commander 1.0.");

while (true)
{
    Console.Write("Commander> ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
    var command = Console.ReadLine();
    System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
    proc.FileName = @"C:\windows\system32\cmd.exe";
    proc.Arguments = $"/c {command}";
    if ( command == "exit" ) {
        return 0;
    }
    System.Diagnostics.Process.Start(proc).WaitForExit();
}