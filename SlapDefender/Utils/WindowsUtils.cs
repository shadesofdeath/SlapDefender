using Microsoft.Win32;
using System.Diagnostics;
using System;
using System.Windows.Forms;

public class WindowsUtils
{
    public static string GetWindowsFriendlyName()
    {
        string ProductName = GetHKEYLocalMachineString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "ProductName");
        string CSDVersion = GetHKEYLocalMachineString(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion", "CSDVersion");

        if (ProductName != "")
        {
            return (ProductName.StartsWith("Microsoft") ? "" : "Microsoft ") +
                ProductName + (CSDVersion != "" ? " " + CSDVersion : "");
        }

        return "";
    }

    private static string GetHKEYLocalMachineString(string path, string key)
    {
        try
        {
            RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(path);

            if (registryKey == null)
            {
                return "";
            }

            return (string)registryKey.GetValue(key);
        }
        catch
        {
            return "";
        }
    }

    public static void RunBatchFile(string batchName)
    {
        String command = Application.StartupPath + "\\" + batchName;
        ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
        processStartInfo.CreateNoWindow = true;
        processStartInfo.UseShellExecute = false;
        processStartInfo.RedirectStandardError = true;
        processStartInfo.RedirectStandardOutput = true;
        Process createdProcess = Process.Start(processStartInfo);
        createdProcess.WaitForExit();
    }
}