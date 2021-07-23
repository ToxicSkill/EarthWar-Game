using System.Drawing;
using System.Windows.Forms;

namespace EarthWarNsp
{
    public partial class SecondWindow : Form
    {
        public SecondWindow(int mode = 0)
        {
            InitializeComponent();
            //Setting window properties according to passed mode
            SetText(mode);
        }

        /// <summary>
        /// Function setting labels text and establishes whith elements are visible, changing window name
        /// </summary>
        /// <param name="mode"></param>
        private void SetText(int mode)
        {
            /*
             * mode 0 -> ABOUT
             * mode 1 -> WIN
             * mode 2 -> LOSE
             */
            if (mode == 0)
            {
                //changing label text to game description
                labelDescription.Text = "You are Russian general. \nYou have to command your soldiers and create strongest army in the world.\n" +
                    "To do that, choose soldiers by DOUBLE-CLICK them. \nChoose wise, soldiers with same friendly property (more or less than 0) are more likely to create better platoon.\n" +
                    "The same dependancy platoons have. Remember you can always freeze the time. \nYou have to get 2 million points. \nYou`ll get extra bonus if at the end of game the divisions will perform each friendly property an even number of times ";
                //changing back color to white smoke
                BackColor = Color.WhiteSmoke;
                //changing visibility of elements
                labelDis.Visible = false;
                labelDescription.Visible = true;
                labelInfo.Visible = false;
                pictureBox1.Visible = true;
                //changing window name to corresponding to mode
                this.Text = "About";
            }
            if (mode == 1)// WIN
            {
                labelDis.Text = "Congratulations! \nYou won the war, world is your.";
                labelInfo.Text = "You won!";
                //changing back color to light green
                BackColor = Color.LightGreen;
                labelDis.Visible = true;
                labelDescription.Visible = false;
                labelInfo.Visible = true;
                pictureBox1.Visible = false;
                this.Text = "Winner!";
            }
            if (mode == 2)// LOSE
            {
                labelDis.Text = "Unfortunately you lose the war. \nGo and kill yourself bloody bastard!";
                labelInfo.Text = "You lose!";
                BackColor = Color.OrangeRed;
                labelDis.Visible = true;
                labelDescription.Visible = false;
                labelInfo.Visible = true;
                pictureBox1.Visible = false;
                this.Text = "Looooser!";
            }
        }
    }
}
