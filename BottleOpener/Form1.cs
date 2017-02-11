using System;
using System.IO;
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
            MessageBox.Show("BottleOpener program launcher by Jean-Simon Desjardins, available at https://www.github.com/jsgarden/BottleOpener", "About BottleOpener");
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
            checkLength();
        }

        /// <summary>
        /// Use this to start an executable from the directory textbox
        /// </summary>
        private void startProgram()
        {
            Process.Start(directoryString);
        }

        private void checkLength()
        {
            if (directoryString.Length > 0)
            {
                startProgram();
            }
            else
            {
                errorNoDirectory();
            }
        }

        private void errorNoDirectory()
        {
            MessageBox.Show("Please enter a valid directory or command in the text box !", "ERROR");
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

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createGodModeFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will create a GodMode folder at the location specified in the directory text box.", "Help - GodMode Folder");
        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            directoryString = textboxDirectory.Text;

            if (directoryString.Length > 0)
            {
                Environment.CurrentDirectory = directoryString; //Set dir to create godmode folder
                Directory.CreateDirectory( "GodMode.{ED7BA470-8E54-465E-825C-99712043E01C}" );

                //Tell the user the godmode folder has been created
                MessageBox.Show( $"A GodMode folder has successfully been created at {directoryString}", "BottleOpener Notification");
            }
            else
            {
                errorNoDirectory();
            }

           
        }

        private void accessibilityOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control access.cpl");
        }

        private void addNewHardwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control sysdm.cpl add new hardware");
        }

        private void addRemoveProgramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control appwiz.cpl");
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control timedate.cpl");
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control desk.cpl");
        }

        private void fontsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control fonts");
        }

        private void internetPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control inetcpl.cpl");
        }

        private void joystickPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control joy.cpl");
        }

        private void modemPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control modem.cpl");
        }

        private void mousePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control main.cpl");
        }

        private void multimediaPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control mmsys.cpl");
        }

        private void printersFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control printers");
        }

        private void regionalSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control intl.cpl");
        }

        private void scannersAndCamerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control sticpl.cpl");
        }

        private void soundPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control mmsys.cpl sounds");
        }

        private void systemPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c " + "control sysdm.cpl");
        }
    }
}
