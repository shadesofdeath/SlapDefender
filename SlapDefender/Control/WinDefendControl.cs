using System.Windows.Forms;

public class WinDefendControl
{
    public static void EnableWindowsDefender()
    {
        try
        {
            if (System.IO.File.Exists("EnableWD.bat"))
            {
                System.IO.File.Delete("EnableWD.bat");
            }
        }
        catch
        {
            MessageBox.Show("Please, ensure that the file 'EnableWD.bat' is not used by another process.", "WinDefendManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        System.IO.File.WriteAllText("EnableWD.bat", SlapDefender.Properties.Resources.EnableWD);
        WindowsUtils.RunBatchFile("EnableWD.bat");

        try
        {
            System.IO.File.Delete("EnableWD.bat");
        }
        catch
        {

        }
    }

    public static void DisableWindowsDefender()
    {
        try
        {
            if (System.IO.File.Exists("DisableWD.bat"))
            {
                System.IO.File.Delete("DisableWD.bat");
            }
        }
        catch
        {
            MessageBox.Show("Please, ensure that the file 'DisableWD.bat' is not used by another process.", "WinDefendManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        System.IO.File.WriteAllText("DisableWD.bat", SlapDefender.Properties.Resources.DisableWD);
        WindowsUtils.RunBatchFile("DisableWD.bat");

        try
        {
            System.IO.File.Delete("DisableWD.bat");
        }
        catch
        {

        }
    }
}