using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BottleOpener
{
    public partial class bottleopener : Form
    {
        string directoryString;

        public bottleopener()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BottleOpener program launcher by Q", "About");
        }

        private void textboxInstructions_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxDirectory_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolstripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void launchbutton_Click(object sender, EventArgs e)
        {
            directoryString = textboxDirectory.Text;
            startProgram();
        }

        private void startProgram()
        {
            Process.Start(directoryString);
        }

        private void textboxDirectory_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxTools_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCMD_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void buttonCMD_Click(object sender, MouseEventArgs e)
        {         

        }

        private void buttonDiskManagement_Click(object sender, EventArgs e)
        {
            Process.Start("diskmgmt.msc");
        }

        private void buttonCommandPrompt_Click(object sender, EventArgs e)
        {
            Process.Start("cmd");
        }

        private void buttonREGedit_Click(object sender, EventArgs e)
        {
            Process.Start("regedit");
        }

        private void buttonPowershellPrompt_Click_1(object sender, EventArgs e)
        {
            Process.Start("taskmgr");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("msinfo32");
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void launchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter the path to the executable you want to launch, then click the 'Launch' button.", "Help - Launch Button");
        }

        private void commandPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the button of the tool you want to open.", "Help - Tools");
        }

        private void commandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click the button command you want to execute. You can put arguments in the text field.", "Help - Commands");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("control");
        }

        private void buttonIPConfiguration_Click(object sender, EventArgs e)
        {
            Process.Start("ipconfig");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void enableTelnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "pkgmgr /iu:”TelnetClient”");
        }

        private void disableTelnetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "pkgmgr /uu:”TelnetClient”");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("devmgmt.msc");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("control main.cpl keyboard");
        }
    }
}
