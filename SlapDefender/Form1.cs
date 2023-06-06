using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SlapDefender
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point lastLocation;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void DisableDefenderBtn_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("DisableWD.bat", SlapDefender.Properties.Resources.DisableWD);
            WindowsUtils.RunBatchFile("DisableWD.bat");
            MessageBox.Show("Defender Successfully Disabled! Please restart your computer for the changes to take effect.", "DefenderSlap", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EnableDefenderBtn_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("EnableWD.bat", SlapDefender.Properties.Resources.EnableWD);
            WindowsUtils.RunBatchFile("EnableWD.bat");
            MessageBox.Show("Defender Successfully Enabled! Please restart your computer for the changes to take effect.", "DefenderSlap", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.File.Delete("DisableWD.bat");
                System.IO.File.Delete("EnableWD.bat"); 
            }
            catch(Exception)
            {
                Application.Exit();
            }
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.buymeacoffee.com/berkayay"));
            Process.Start(new ProcessStartInfo("https://github.com/shadesofdeath"));
        }

        private void kucult_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.Location.X - lastLocation.X;
                int deltaY = e.Location.Y - lastLocation.Y;
                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.buymeacoffee.com/berkayay"));
            Process.Start(new ProcessStartInfo("https://github.com/shadesofdeath"));
        }
    }
}
