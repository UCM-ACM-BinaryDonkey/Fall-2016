using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RoundShield
{
    static class Constants
    {
        public const bool Debug = true;
    }
    public partial class RS_MainWindow : Form
    {
        public RS_MainWindow()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //When it Loads it takes up the entire working space
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            EngineSettings.Default.ScreenX = Screen.PrimaryScreen.WorkingArea.Width;
            EngineSettings.Default.ScreenY = Screen.PrimaryScreen.WorkingArea.Height;
            EngineSettings.Default.Save();
            //Saves Values of Window Size To Settings File
            //This Will Be Used Later to Scale World Properly

            //This is Debug Code
            if (Constants.Debug)
            {
                label1.Text = EngineSettings.Default.ScreenX.ToString();
                label2.Text = EngineSettings.Default.ScreenY.ToString();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //DO NOT DELETE THIS?
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //This is the Exit Button On The Dev Side
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Dont Delete
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Background
        }



        
    }
}
