using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using chuck;

namespace RoundShield
{
    
    public partial class RS_MainWindow : Form
    {
        public RS_MainWindow()
        {
            InitializeComponent();
        }
        static class Constants
        {
            public const bool Debug = true;
            public const bool Release = false;
            const int numofitems = 10;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //When it Loads it takes up the entire working space
            this.Location = new Point(0, 0);
            this.Anchor = AnchorStyles.Top;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            EngineSettings.Default.ScreenX = Screen.PrimaryScreen.WorkingArea.Width;
            EngineSettings.Default.ScreenY = Screen.PrimaryScreen.WorkingArea.Height;
            EngineSettings.Default.Save();
            //Saves Values of Window Size To Settings File
            //This Will Be Used Later to Scale World Properly

            Startup();

            //This is Debug Code
            if (Constants.Debug)
            {
                label1.Text = EngineSettings.Default.ScreenX.ToString();
                label2.Text = EngineSettings.Default.ScreenY.ToString();
                devToolStripMenuItem.Visible = true;
                //groupBox1.Height = EngineSettings.Default.ScreenY - 28;
            }
            else
            {
                if(Constants.Release)
                {
                    MainMenuStrip.Visible = false;
                    //groupBox1.Height = EngineSettings.Default.ScreenY;
                }
                else
                {
                    devToolStripMenuItem.Visible = false;
                }
            }
        }
        //Tool Strip
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //This is the Exit Button On The Dev Side
            Application.Exit();
        }
        //This is the Exit From Context Menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void move(int a)
        {

        }
        private void Startup()
        {
            //Loads up the TestBox
            TESTBOX.Location = new Point(EngineSettings.Default.ScreenX/3, EngineSettings.Default.ScreenY/3);
            
            
            //Does Map Tiles
            PictureBox[,] map = new PictureBox[5,5];

            for(int i = 0 ; i <5;i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    map[i, j] = new PictureBox();
                    map[i, j].Visible = true;
                    map[i, j].Image = Properties.Resources.TestTile_3;
                    map[i,j].Size =  new System.Drawing.Size(64,64);
                    map[i, j].Location = new Point(((64 * i)+200), ((64 * j)+200));
                }
            }
        }
    }
}
