using System.Diagnostics;

namespace Betting_Boys_V2.Server
{
    public class GetCurrentNFLWeek
    {

    public static string GetWeek()
    {
        var psi = new ProcessStartInfo
        {
            FileName = "python",
            Arguments = "get_week.py",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        using var process = Process.Start(psi);
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        return output.Trim();
    }

}
}
