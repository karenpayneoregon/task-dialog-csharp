using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsLibrary.Classes
{
    public class PowerShellOperations
    {
        public static string ComputerInfoFileName => "computerInformation.json";
        public static async Task<MachineComputerInformation> GetComputerInformationTask()
        {

            if (File.Exists(ComputerInfoFileName))
            {
                File.Delete(ComputerInfoFileName);
            }

            var start = new ProcessStartInfo
            {
                FileName = "powershell.exe",
                RedirectStandardOutput = true,
                Arguments = "Get-ComputerInfo | ConvertTo-Json",
                CreateNoWindow = true
            };

            using var process = Process.Start(start);
            using var reader = process.StandardOutput;

            process.EnableRaisingEvents = true;

            var fileContents = await reader.ReadToEndAsync();

            await File.WriteAllTextAsync(ComputerInfoFileName, fileContents);
            await process.WaitForExitAsync();

            var json = await File.ReadAllTextAsync(ComputerInfoFileName);
            return JsonConvert.DeserializeObject<MachineComputerInformation>(json);

        }
    }
}
