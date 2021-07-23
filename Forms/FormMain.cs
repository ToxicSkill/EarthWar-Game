using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace EarthWarNsp
{
    public partial class FormMain : Form
    {
        //initializing frames array for gif picture management 
        public Image[] frames;
        private int iteratorGIF = 0;

        //second window initialize (for about, win and lose)
        private SecondWindow secondWindow;

        //variable for days counter
        private static int daysLeft = 69;

        //variables for labels properties
        public int powerPlatoons = 0,
            powerSoldiers = 0,
            powerDivision = 0,
            friendlySoldiers = 0,
            frienldyPlatoons = 0,
            friendlyDivision = 0;

        //Lists of classes used by data grid views
        private List<Soldier> soldiers = new List<Soldier>();
        private readonly List<Soldier> choosenSoldiers = new List<Soldier>();

        private List<Platoon> platoons = new List<Platoon>();
        private readonly List<Platoon> choosenPlatoons = new List<Platoon>();

        private readonly List<Division> divisions = new List<Division>();

        //List of data grids for better management
        private readonly List<DataGridView> dataGrids = new List<DataGridView>();

        public FormMain()
        {
            InitializeComponent();

            //changing back color to blue
            BackColor = Color.FromArgb(81, 104, 172);

            //function for create grid list elements
            CreateDataGridsLists();

            //function for set loading progress bar and timer
            SetLoadingTimer();
        }

        /// <summary>
        /// Function for data grid list fill
        /// </summary>
        private void CreateDataGridsLists()
        {
            //adding data grids types to the list of them
            dataGrids.Add(dataGridViewSoldier);
            dataGrids.Add(dataGridViewPlatoon);
            dataGrids.Add(dataGridViewDivision);
        }

        /// <summary>
        /// Function sets max progress bar value and starts timer for loading 
        /// </summary>
        private void SetLoadingTimer()
        {
            //setting progress bar maximum range
            progressBarLoading.Maximum = 50;
            //starting loading timer
            timerLoading.Start();
        }

        /// <summary>
        /// Function sets progress bar progess increment and stops timer when loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerLoading_Tick(object sender, EventArgs e)
        {
            //checking if progress bar still goes on -> if not, switching off timer loading
            timerLoading.Enabled = progressBarLoading.Value++ == progressBarLoading.Maximum - 1 ? false : true;
            //if timer is off, switching off progress bar loading
            if (!timerLoading.Enabled)
            {
                // stopping loading timer 
                timerLoading.Stop();
                // disabling progress bar
                progressBarLoading.Enabled = false;
            }
        }

        /// <summary>
        /// Function sets visibility of elements and starting timer for days -> activated after loading page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void progressBarLoading_EnabledChanged(object sender, EventArgs e)
        {
            //change visibility of elements
            SetVisibility();
            //get GIF frames
            SetGifFrames();
            //start day timer
            timerDay.Start();
        }

        /// <summary>
        /// Button for freezing time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStopDay_Click(object sender, EventArgs e)
        {
            //function for freezing day timer
            StopDay();
        }

        /// <summary>
        /// Button for displaying About window (second window)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            //Stop day timer permanently
            StopDay(true);
            //Show second window (default mode) 
            secondWindow = new SecondWindow();
            secondWindow.Show();
        }

        /// <summary>
        /// Function for freezing time
        /// </summary>
        /// <param name="permanent"></param>
        private void StopDay(bool permanent = false)
        {
            //if freeze must be permanent
            if(permanent)
                timerDay.Enabled = false;
            else //if not, change for opposite
                timerDay.Enabled = !timerDay.Enabled;
            //Chaning button text
            buttonStopDay.Text = timerDay.Enabled ? "Freeze time" : "Start time";
            //Changing earth rotation 
            pictureBoxSamllEarth.Enabled = timerDay.Enabled ? true : false;
        }

        /// <summary>
        /// Function sets visibility of elements
        /// </summary>
        private void SetVisibility()
        {
            progressBarLoading.Visible = false;
            labelLoading.Visible = false;
            pictureBoxEarthGif.Visible = false;
            pictureBoxEarthGif.Enabled = false;
            pictureBoxSamllEarth.Visible = true;
            dataGridViewSoldier.Visible = true;
            dataGridViewPlatoon.Visible = true;
            dataGridViewDivision.Visible = true;
            labelDaysLeft.Visible = true;
            labelSoldiers.Visible = true;
            labelPlatoons.Visible = true;
            labelDivisionPower.Visible = true;
            labelDivisions.Visible = true;
            labelDivisionsPowerLabel.Visible = true;
            labelChoosenSoldiers.Visible = true;
            labelChoosenPlatoons.Visible = true;
            buttonStopDay.Visible = true;
            buttonCreatePlatoon.Visible = true;
            buttonCreateDivision.Visible = true;
            buttonAbout.Visible = true;
            pictureBoxFire.Visible = true;
            pictureBoxFire2.Visible = true;
            pictureBoxFire3.Visible = true;
            pictureBoxDN.Visible = true;
        }

        /// <summary>
        /// Function gets clock GIF frames 
        /// </summary>
        private void SetGifFrames()
        {
            //to do than, gif must be stopped
            pictureBoxDayNight.Visible = false;
            pictureBoxDayNight.Enabled = false;

            //initializing new image as clock gif
            Image pictureGIF = pictureBoxDayNight.Image;
            //initializing new frame dimension variable 
            FrameDimension dimension = new FrameDimension(pictureGIF.FrameDimensionsList[0]);

            // Number of frames
            int frameCount = pictureGIF.GetFrameCount(dimension);
            //initializing frames size
            frames = new Image[frameCount];

            int i;
            // Return an Image at a certain index
            for (i = 1; i < frameCount; ++i)
            {
                //selectiong active frame
                pictureGIF.SelectActiveFrame(dimension, i);
                frames[i - 1] = new Bitmap(pictureGIF);
            }
            //remember about last element
            frames[i - 1] = new Bitmap(pictureGIF);
        }

        /// <summary>
        /// A function that handles calling the timer day
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerDay_Tick(object sender, EventArgs e)
        {
            //if actual frame is last frame
            if (iteratorGIF == frames.Count())
            {
                //decrement days left and update label
                labelDaysLeft.Text = "Days left: " + daysLeft--.ToString();
                //reset gif iterator
                iteratorGIF = 0;

                //create new soldier (1 day - 1 soldier)
                CreateSoldier();
                //update constrains of new data grid
                SetDataConstrainsSoldiers();
                //update fire size
                SetFireSize();

                //if the last day is over
                if (daysLeft < 0)
                {
                    //stop day timer permanently
                    StopDay(true);
                    //if player reached 2 milions or more points
                    if (powerDivision >= 2e6) // if player reached 2 milion points
                    {
                        //initialize new window in WIN mode (1)
                        secondWindow = new SecondWindow(1);
                        //hide actual window
                        this.Hide();
                        //close this window when second is closed
                        secondWindow.Closed += (s, args) => this.Close();
                        secondWindow.Show();
                    }
                    else// if player reached less than 2 milion points
                    {
                        //same as previous byt in LOSE mode
                        secondWindow = new SecondWindow(2);
                        this.Hide();
                        secondWindow.Closed += (s, args) => this.Close();
                        secondWindow.Show();
                    }
                }
            }
            //set actual clock gif frame
            pictureBoxDN.Image = frames[iteratorGIF];
            //iterate gif iterator
            iteratorGIF++;
        }

        /// <summary>
        /// Function sets fires size
        /// </summary>
        private void SetFireSize()
        {
            //if there are more than 20 soldier, change fire box 1.5 times, also relocate it
            if (soldiers.Count > 20)
            {
                pictureBoxFire.Width = 150;
                pictureBoxFire.Height = 150;
                pictureBoxFire.Location = new Point(100, 250);
            }
            else // if there are less than 20 soldiers
            {
                pictureBoxFire.Width = 100;
                pictureBoxFire.Height = 100;
                pictureBoxFire.Location = new Point(125, 300);
            }
            if (platoons.Count > 10) //10 platoons
            {
                pictureBoxFire2.Width = 150;
                pictureBoxFire2.Height = 150;
                pictureBoxFire2.Location = new Point(461, 250);
            }
            else
            {
                pictureBoxFire2.Width = 100;
                pictureBoxFire2.Height = 100;
                pictureBoxFire2.Location = new Point(486, 300);
            }
            if (divisions.Count > 5)// 5 divisions
            {
                pictureBoxFire3.Width = 150;
                pictureBoxFire3.Height = 150;
                pictureBoxFire3.Location = new Point(820, 250);
            }
            else
            {
                pictureBoxFire3.Width = 100;
                pictureBoxFire3.Height = 100;
                pictureBoxFire3.Location = new Point(845, 300);
            }
        }

        /// <summary>
        /// Function sets data gird soldiers
        /// </summary>
        private void SetDataConstrainsSoldiers()
        {
            //only if there are soldiers
            if (soldiers.Count != 0)
            {
                //change each column width to 50 and change alignment of text inside
                for (int i = 0; i < dataGridViewSoldier.Columns.Count; ++i)
                {
                    dataGridViewSoldier.Columns[i].Width = 50;
                    dataGridViewSoldier.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                //ID column has to be first
                dataGridViewSoldier.Columns["ID"].DisplayIndex = 0;

                //ID column has to be narrow
                dataGridViewSoldier.Columns[5].Width = 30;
                //POWER column has to be wide
                dataGridViewSoldier.Columns[3].Width = 70;

                //Adding units text for height and weight columns
                dataGridViewSoldier.Columns[1].HeaderText += " [m]";
                dataGridViewSoldier.Columns[2].HeaderText += " [kg]";

                //checking which row is selected and changing selected rows color to dark khaki
                for (var i = 0; i < dataGridViewSoldier.Rows.Count; ++i)
                {
                    for (var j = 0; j < choosenSoldiers.Count; ++j)
                    {
                        if (soldiers[i].ID == choosenSoldiers[j].ID)
                        {
                            dataGridViewSoldier.Rows[i].DefaultCellStyle.BackColor = Color.DarkKhaki;
                            break;
                        }
                        else
                            dataGridViewSoldier.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        /// <summary>
        /// Function sets data gird platoons and divisions
        /// </summary>
        private void SetDataConstrainsPlatoonsDivsions()
        {
            //choosing which data grids are checking
            //chnging alignmet to center, changing width and diplay order
            for (var index = 1; index < 3; ++index)
            {
                for (int i = 0; i < dataGrids[index].Columns.Count; ++i)
                    dataGrids[index].Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (dataGrids[index].Rows.Count != 0)
                {
                    dataGrids[index].Columns["ID"].DisplayIndex = 0;

                    dataGrids[index].Columns["ID"].Width = 50;
                    dataGrids[index].Columns["Power"].Width = 100;
                    dataGrids[index].Columns["Friendly"].Width = 70;
                }
            }

            //Checking which row is selected and changing selected rows color to dark khaki
            for (var i = 0; i < dataGridViewPlatoon.Rows.Count; ++i)
            {
                for (var j = 0; j < choosenPlatoons.Count; ++j)
                {
                    if (platoons[i].ID == choosenPlatoons[j].ID)
                    {
                        dataGridViewPlatoon.Rows[i].DefaultCellStyle.BackColor = Color.DarkSalmon;
                        break;
                    }
                    else
                        dataGridViewPlatoon.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        /// <summary>
        ///  A function that handles double - click soldier cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewSoldier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Sending to double click function
            DoubleClicked(sender, e);
        }

        /// <summary>
        /// A function that handles double - click platoon cell
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewPlatoon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DoubleClicked(sender, e);
        }

        /// <summary>
        /// Function checking double clicked rows and creates or removes lists elements corresponding to passed type
        /// </summary>
        /// <param name="dataSender"></param>
        /// <param name="e"></param>
        /// <param name="type"></param>
        private void DoubleClicked(object dataSender, DataGridViewCellEventArgs e)
        {
            //creating new object in DataGridView type, to assign sender type to it
            DataGridView data = new DataGridView();

            //creating new color variable
            Color color = new Color();

            //bool (soldier) variable for checking wheater soldier mode or platoon is on
            bool soldier = false,
                stop = false;//stop to assign true if exception catched

            //checking if dataSender is actualy correct type
            if (dataSender.Equals(dataGrids[0]))
            {
                //assign type to data
                data = dataGrids[0];
                soldier = true; //setting mode
                color = Color.DarkKhaki; //setting color for soldier
            }
            else if (dataSender.Equals(dataGrids[1]))
            {
                data = dataGrids[1];
                color = Color.DarkSalmon;
                //soldier stays false
            }

            //if choosen (double - clicked) row exist ( -1 if not)
            if (e.RowIndex >= 0)
            {
                //potentially dangerous
                try
                {
                    if (soldier)//if soldier mode
                    {
                        //searching for soldier with exact ID -> choosen soldier ID
                        Soldier solFound = choosenSoldiers.Where(x => x.ID == soldiers[e.RowIndex].ID).FirstOrDefault();
                        if (solFound == null)//if that soldier doesnt exist
                        {
                            //adding soldier to choosen soldiers list
                            choosenSoldiers.Add(soldiers[e.RowIndex]);
                            //painting choosen row in soldier color
                            data.Rows[e.RowIndex].DefaultCellStyle.BackColor = color;
                        }
                        else// if choosen soldier already exist - > uncheck him
                        {
                            //removing choosen soldier from list
                            choosenSoldiers.Remove(solFound);
                            //repaint cell to default color
                            data.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                    else//if its platoon instead of soldier
                    {
                        Platoon platFound = choosenPlatoons.Where(x => x.ID == platoons[e.RowIndex].ID).FirstOrDefault();
                        if (platFound == null)
                        {
                            choosenPlatoons.Add(platoons[e.RowIndex]);
                            data.Rows[e.RowIndex].DefaultCellStyle.BackColor = color;
                        }
                        else
                        {
                            choosenPlatoons.Remove(platFound);
                            data.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        }
                    }
                }
                //if operation failed
                catch { stop = true; }//change stop from false to true 

                //only if previous operation succeed
                if (!stop)
                {
                    //creating new list for checking variety of friendly soldiers
                    List<int> variety = new List<int>();

                    //reset values 
                    powerSoldiers = 0;
                    friendlySoldiers = 0;

                    //creating bools variables to check differentiation of friendly properties 
                    bool positive;
                    bool negative;

                    //if elements exist
                    if (soldiers.Count != 0)
                    {
                        //computing power for each element of power and friendly 
                        foreach (var sol in choosenSoldiers)
                        {
                            powerSoldiers += sol.ComputePower(sol);//assign straight to power
                            variety.Add(sol.ComputeFriendly(sol)); //adding to list
                        }

                        //checking if variety list contains only positive or negatove values
                        positive = variety.All(x => x > 0);
                        negative = variety.All(x => x <= 0);

                        //computing sum of variety elements (friendly)
                        foreach (var element in variety)
                            friendlySoldiers += element;

                        //adding or subtracting values in depending on differentiation
                        if (positive && !negative)
                            friendlySoldiers += (int)(friendlySoldiers * 1.5); //add if there are only positive elements
                        else if (!positive && negative)
                            friendlySoldiers += (int)(friendlySoldiers * 1.5); //add if there are only negative elements
                        else
                            friendlySoldiers /= 2; //reduce twice if there are positive and negative values

                        //adding friendly bonus to power 
                        powerSoldiers += Math.Abs(friendlySoldiers);

                        //clear list
                        variety.Clear();
                    }

                    //reset values fo platoon
                    powerPlatoons = 0;
                    frienldyPlatoons = 0;

                    //exactly the same but for platoons
                    if (platoons.Count != 0)
                    {
                        foreach (var plat in choosenPlatoons)
                        {
                            powerPlatoons += plat.ComputePower(plat);
                            variety.Add(plat.ComputeFriendly(plat));
                        }

                        positive = variety.All(x => x > 0);
                        negative = variety.All(x => x <= 0);

                        foreach (var element in variety)
                            frienldyPlatoons += element;

                        if (positive && !negative)
                            frienldyPlatoons += (int)(frienldyPlatoons * 1.5);
                        else if (!positive && negative)
                            frienldyPlatoons += (int)(frienldyPlatoons * 1.5);
                        else
                            frienldyPlatoons /= 2;

                        powerPlatoons += Math.Abs(frienldyPlatoons);
                    }
                    UpdatePowerLabels(powerSoldiers, powerPlatoons);
                }
            }

        }

        /// <summary>
        /// Function sets labels text (power)
        /// </summary>
        /// <param name="powerSoldier"></param>
        /// <param name="powerPlatoon"></param>
        private void UpdatePowerLabels(int powerSoldier = 0, int powerPlatoon = 0)
        {
            labelChoosenSoldiers.Text = "Choosen soldiers power: " + powerSoldier.ToString();
            labelChoosenPlatoons.Text = "Choosen platoons power: " + powerPlatoon.ToString();
            labelDivisionsPowerLabel.Text = powerDivision.ToString();
        }

        /// <summary>
        /// A function that handles creating platoon button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreatePlatoon_Click(object sender, EventArgs e)
        {
            //if there are elements to create bigger structure (at least 2 elements)
            if (choosenSoldiers.Count > 1)
            {
                //creating temporary list of soldiers
                List<Soldier> temp = new List<Soldier>();
                //bool variable for choosen soldier
                bool choosen = false;

                //Creating new platoon (of choosen soldiers)
                CreatePlatoon();

                //checking which soldiers were choose and excluding them from soldiers list
                for (var i = 0; i < soldiers.Count; ++i)
                {
                    for (var j = 0; j < choosenSoldiers.Count; ++j)
                        if (soldiers[i].ID == choosenSoldiers[j].ID)
                            choosen = true;
                    if (!choosen)
                        temp.Add(soldiers[i]);
                    choosen = false;
                }

                //assign temporary list of soldiers to main list of them
                soldiers = new List<Soldier>(temp);

                //clearing all unnecessary lists
                temp.Clear();
                choosenSoldiers.Clear();

                //after changes, updating (power) labels and grid data
                UpdateSoldierGrid();
                UpdatePowerLabels(0, powerPlatoons);

                //changing data grids constrains to custom one
                SetDataConstrainsSoldiers();
                SetDataConstrainsPlatoonsDivsions();
            }
        }


        /// <summary>
        /// A function that handles creating division button click
        /// Same mode of action as buttonCreatePlatoon_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateDivision_Click(object sender, EventArgs e)
        {
            if (choosenPlatoons.Count > 1)
            {
                List<Platoon> temp = new List<Platoon>();
                bool choosen = false;

                CreateDivision();

                for (var i = 0; i < platoons.Count; ++i)
                {
                    for (var j = 0; j < choosenPlatoons.Count; ++j)
                        if (platoons[i].ID == choosenPlatoons[j].ID)
                            choosen = true;
                    if (!choosen)
                        temp.Add(platoons[i]);
                    choosen = false;
                }

                platoons = new List<Platoon>(temp);
                temp.Clear();
                choosenPlatoons.Clear();

                UpdatePlatoonGrid();
                UpdatePowerLabels();

                UpdatePowerLabels(powerSoldiers, 0);
                SetDataConstrainsPlatoonsDivsions();
            }
        }

        /// <summary>
        /// Function creates new soldier 
        /// </summary>
        private void CreateSoldier()
        {
            //add new solier to soldiers list
            soldiers.Add(new Soldier());
            //update soldier data grid
            UpdateSoldierGrid();
        }

        /// <summary>
        /// Function creates new platoon
        /// </summary>
        private void CreatePlatoon()
        {
            //creating new platton with given power and friendly properties
            platoons.Add(new Platoon(powerSoldiers, friendlySoldiers));
            //update platoon data grid
            UpdatePlatoonGrid();
        }

        /// <summary>
        /// Function creates division
        /// </summary>
        private void CreateDivision()
        {
            //creating new division with given power and friendly properties
            divisions.Add(new Division(powerPlatoons, frienldyPlatoons));
            UpdateDivisionGrid();

            //adding values of new divisions
            powerDivision += divisions[divisions.Count - 1].Power;
            friendlyDivision += divisions[divisions.Count - 1].Friendly;

            //checking what elements contains only negative or positive friendly popreties
            List<Division> posDiv = divisions.Where(x => x.Friendly > 0).ToList();
            List<Division> negDiv = divisions.Where(x => x.Friendly <= 0).ToList();

            //checking if it has occurred an even number of times
            if (posDiv.Count % 2 == 0 && negDiv.Count % 2 == 0)
                powerDivision += (int)Math.Round(powerDivision * 1.5); // adding bonus if occurred

            //repainting row color to crimson
            for (var i = 0; i < dataGridViewDivision.Rows.Count; ++i)
                dataGridViewDivision.Rows[i].DefaultCellStyle.BackColor = Color.Crimson;
        }

        /// <summary>
        /// Function updates soldier data grid
        /// </summary>
        private void UpdateSoldierGrid()
        {//checking if division has members
            if (soldiers.Count != 0)
            { //assign division list as data source
                dataGridViewSoldier.DataSource = typeof(List<Soldier>);
                dataGridViewSoldier.DataSource = soldiers;
            }
            else//if there are no element, clear data grid
                dataGridViewSoldier.DataSource = null;
        }

        /// <summary>
        /// Function updates platoon data grid
        /// </summary>
        private void UpdatePlatoonGrid()
        {//checking if division has members
            if (platoons.Count != 0)
            { //assign division list as data source
                dataGridViewPlatoon.DataSource = typeof(List<Platoon>);
                dataGridViewPlatoon.DataSource = platoons;
            }
            else//if there are no element, clear data grid
                dataGridViewPlatoon.DataSource = null;
        }

        /// <summary>
        /// Function updates division data grid
        /// </summary>
        private void UpdateDivisionGrid()
        {
            //checking if division has members
            if (divisions.Count != 0)
            {
                //assign division list as data source
                dataGridViewDivision.DataSource = typeof(List<Division>);
                dataGridViewDivision.DataSource = divisions;
            }
            else //if there are no element, clear data grid
                dataGridViewDivision.DataSource = null;
        }
    }
}
