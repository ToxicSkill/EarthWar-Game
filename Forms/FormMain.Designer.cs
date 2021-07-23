
namespace EarthWarNsp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.labelLoading = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.timerDay = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewSoldier = new System.Windows.Forms.DataGridView();
            this.buttonStopDay = new System.Windows.Forms.Button();
            this.labelDaysLeft = new System.Windows.Forms.Label();
            this.dataGridViewPlatoon = new System.Windows.Forms.DataGridView();
            this.labelSoldiers = new System.Windows.Forms.Label();
            this.labelPlatoons = new System.Windows.Forms.Label();
            this.labelChoosenSoldiers = new System.Windows.Forms.Label();
            this.buttonCreatePlatoon = new System.Windows.Forms.Button();
            this.buttonCreateDivision = new System.Windows.Forms.Button();
            this.labelChoosenPlatoons = new System.Windows.Forms.Label();
            this.dataGridViewDivision = new System.Windows.Forms.DataGridView();
            this.labelDivisions = new System.Windows.Forms.Label();
            this.labelDivisionPower = new System.Windows.Forms.Label();
            this.labelDivisionsPowerLabel = new System.Windows.Forms.Label();
            this.pictureBoxSamllEarth = new System.Windows.Forms.PictureBox();
            this.pictureBoxDN = new System.Windows.Forms.PictureBox();
            this.pictureBoxFire3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFire2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFire = new System.Windows.Forms.PictureBox();
            this.pictureBoxEarthGif = new System.Windows.Forms.PictureBox();
            this.pictureBoxDayNight = new System.Windows.Forms.PictureBox();
            this.buttonAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoldier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSamllEarth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEarthGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDayNight)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarLoading.Location = new System.Drawing.Point(45, 862);
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(937, 41);
            this.progressBarLoading.TabIndex = 1;
            this.progressBarLoading.EnabledChanged += new System.EventHandler(this.progressBarLoading_EnabledChanged);
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoading.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(450, 912);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(187, 30);
            this.labelLoading.TabIndex = 2;
            this.labelLoading.Text = "Loading...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 50;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // timerDay
            // 
            this.timerDay.Interval = 10;
            this.timerDay.Tick += new System.EventHandler(this.timerDay_Tick);
            // 
            // dataGridViewSoldier
            // 
            this.dataGridViewSoldier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewSoldier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSoldier.Location = new System.Drawing.Point(5, 539);
            this.dataGridViewSoldier.Name = "dataGridViewSoldier";
            this.dataGridViewSoldier.Size = new System.Drawing.Size(351, 390);
            this.dataGridViewSoldier.TabIndex = 6;
            this.dataGridViewSoldier.Visible = false;
            this.dataGridViewSoldier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSoldier_CellDoubleClick);
            // 
            // buttonStopDay
            // 
            this.buttonStopDay.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStopDay.Location = new System.Drawing.Point(57, 163);
            this.buttonStopDay.Name = "buttonStopDay";
            this.buttonStopDay.Size = new System.Drawing.Size(232, 41);
            this.buttonStopDay.TabIndex = 7;
            this.buttonStopDay.Text = "Freeze time";
            this.buttonStopDay.UseVisualStyleBackColor = true;
            this.buttonStopDay.Visible = false;
            this.buttonStopDay.Click += new System.EventHandler(this.buttonStopDay_Click);
            // 
            // labelDaysLeft
            // 
            this.labelDaysLeft.AutoEllipsis = true;
            this.labelDaysLeft.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaysLeft.Location = new System.Drawing.Point(24, 112);
            this.labelDaysLeft.Name = "labelDaysLeft";
            this.labelDaysLeft.Size = new System.Drawing.Size(298, 39);
            this.labelDaysLeft.TabIndex = 8;
            this.labelDaysLeft.Text = "Days left: 70";
            this.labelDaysLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDaysLeft.Visible = false;
            // 
            // dataGridViewPlatoon
            // 
            this.dataGridViewPlatoon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewPlatoon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlatoon.Location = new System.Drawing.Point(401, 539);
            this.dataGridViewPlatoon.Name = "dataGridViewPlatoon";
            this.dataGridViewPlatoon.Size = new System.Drawing.Size(270, 390);
            this.dataGridViewPlatoon.TabIndex = 9;
            this.dataGridViewPlatoon.Visible = false;
            this.dataGridViewPlatoon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlatoon_CellDoubleClick);
            // 
            // labelSoldiers
            // 
            this.labelSoldiers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSoldiers.AutoEllipsis = true;
            this.labelSoldiers.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoldiers.Location = new System.Drawing.Point(84, 495);
            this.labelSoldiers.Name = "labelSoldiers";
            this.labelSoldiers.Size = new System.Drawing.Size(197, 41);
            this.labelSoldiers.TabIndex = 10;
            this.labelSoldiers.Text = "Soldiers";
            this.labelSoldiers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSoldiers.Visible = false;
            // 
            // labelPlatoons
            // 
            this.labelPlatoons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPlatoons.AutoEllipsis = true;
            this.labelPlatoons.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlatoons.Location = new System.Drawing.Point(438, 495);
            this.labelPlatoons.Name = "labelPlatoons";
            this.labelPlatoons.Size = new System.Drawing.Size(197, 41);
            this.labelPlatoons.TabIndex = 11;
            this.labelPlatoons.Text = "Platoons";
            this.labelPlatoons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlatoons.Visible = false;
            // 
            // labelChoosenSoldiers
            // 
            this.labelChoosenSoldiers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelChoosenSoldiers.AutoEllipsis = true;
            this.labelChoosenSoldiers.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoosenSoldiers.Location = new System.Drawing.Point(6, 409);
            this.labelChoosenSoldiers.Name = "labelChoosenSoldiers";
            this.labelChoosenSoldiers.Size = new System.Drawing.Size(353, 41);
            this.labelChoosenSoldiers.TabIndex = 12;
            this.labelChoosenSoldiers.Text = "Choosen soldiers power: 0";
            this.labelChoosenSoldiers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChoosenSoldiers.Visible = false;
            // 
            // buttonCreatePlatoon
            // 
            this.buttonCreatePlatoon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreatePlatoon.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreatePlatoon.Location = new System.Drawing.Point(78, 453);
            this.buttonCreatePlatoon.Name = "buttonCreatePlatoon";
            this.buttonCreatePlatoon.Size = new System.Drawing.Size(209, 41);
            this.buttonCreatePlatoon.TabIndex = 13;
            this.buttonCreatePlatoon.Text = "Create platoon";
            this.buttonCreatePlatoon.UseVisualStyleBackColor = true;
            this.buttonCreatePlatoon.Visible = false;
            this.buttonCreatePlatoon.Click += new System.EventHandler(this.buttonCreatePlatoon_Click);
            // 
            // buttonCreateDivision
            // 
            this.buttonCreateDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateDivision.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateDivision.Location = new System.Drawing.Point(432, 453);
            this.buttonCreateDivision.Name = "buttonCreateDivision";
            this.buttonCreateDivision.Size = new System.Drawing.Size(209, 41);
            this.buttonCreateDivision.TabIndex = 15;
            this.buttonCreateDivision.Text = "Create division";
            this.buttonCreateDivision.UseVisualStyleBackColor = true;
            this.buttonCreateDivision.Visible = false;
            this.buttonCreateDivision.Click += new System.EventHandler(this.buttonCreateDivision_Click);
            // 
            // labelChoosenPlatoons
            // 
            this.labelChoosenPlatoons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelChoosenPlatoons.AutoEllipsis = true;
            this.labelChoosenPlatoons.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoosenPlatoons.Location = new System.Drawing.Point(360, 409);
            this.labelChoosenPlatoons.Name = "labelChoosenPlatoons";
            this.labelChoosenPlatoons.Size = new System.Drawing.Size(353, 41);
            this.labelChoosenPlatoons.TabIndex = 14;
            this.labelChoosenPlatoons.Text = "Choosen platoons power: 0";
            this.labelChoosenPlatoons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelChoosenPlatoons.Visible = false;
            // 
            // dataGridViewDivision
            // 
            this.dataGridViewDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewDivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDivision.Location = new System.Drawing.Point(760, 539);
            this.dataGridViewDivision.Name = "dataGridViewDivision";
            this.dataGridViewDivision.Size = new System.Drawing.Size(270, 390);
            this.dataGridViewDivision.TabIndex = 16;
            this.dataGridViewDivision.Visible = false;
            // 
            // labelDivisions
            // 
            this.labelDivisions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDivisions.AutoEllipsis = true;
            this.labelDivisions.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivisions.Location = new System.Drawing.Point(797, 495);
            this.labelDivisions.Name = "labelDivisions";
            this.labelDivisions.Size = new System.Drawing.Size(197, 41);
            this.labelDivisions.TabIndex = 17;
            this.labelDivisions.Text = "Divisions";
            this.labelDivisions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDivisions.Visible = false;
            // 
            // labelDivisionPower
            // 
            this.labelDivisionPower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDivisionPower.AutoEllipsis = true;
            this.labelDivisionPower.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivisionPower.Location = new System.Drawing.Point(719, 409);
            this.labelDivisionPower.Name = "labelDivisionPower";
            this.labelDivisionPower.Size = new System.Drawing.Size(353, 41);
            this.labelDivisionPower.TabIndex = 18;
            this.labelDivisionPower.Text = "Your divisions power:";
            this.labelDivisionPower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDivisionPower.Visible = false;
            // 
            // labelDivisionsPowerLabel
            // 
            this.labelDivisionsPowerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDivisionsPowerLabel.AutoEllipsis = true;
            this.labelDivisionsPowerLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDivisionsPowerLabel.Location = new System.Drawing.Point(719, 453);
            this.labelDivisionsPowerLabel.Name = "labelDivisionsPowerLabel";
            this.labelDivisionsPowerLabel.Size = new System.Drawing.Size(353, 41);
            this.labelDivisionsPowerLabel.TabIndex = 19;
            this.labelDivisionsPowerLabel.Text = "0";
            this.labelDivisionsPowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDivisionsPowerLabel.Visible = false;
            // 
            // pictureBoxSamllEarth
            // 
            this.pictureBoxSamllEarth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSamllEarth.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSamllEarth.Image = global::EarthWarNsp.Properties.Resources.earth;
            this.pictureBoxSamllEarth.Location = new System.Drawing.Point(799, 12);
            this.pictureBoxSamllEarth.Name = "pictureBoxSamllEarth";
            this.pictureBoxSamllEarth.Size = new System.Drawing.Size(192, 192);
            this.pictureBoxSamllEarth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSamllEarth.TabIndex = 23;
            this.pictureBoxSamllEarth.TabStop = false;
            this.pictureBoxSamllEarth.Visible = false;
            // 
            // pictureBoxDN
            // 
            this.pictureBoxDN.Location = new System.Drawing.Point(440, 12);
            this.pictureBoxDN.Name = "pictureBoxDN";
            this.pictureBoxDN.Size = new System.Drawing.Size(192, 192);
            this.pictureBoxDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDN.TabIndex = 5;
            this.pictureBoxDN.TabStop = false;
            this.pictureBoxDN.Visible = false;
            // 
            // pictureBoxFire3
            // 
            this.pictureBoxFire3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxFire3.Image = global::EarthWarNsp.Properties.Resources.fire;
            this.pictureBoxFire3.Location = new System.Drawing.Point(845, 300);
            this.pictureBoxFire3.Name = "pictureBoxFire3";
            this.pictureBoxFire3.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFire3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFire3.TabIndex = 22;
            this.pictureBoxFire3.TabStop = false;
            this.pictureBoxFire3.Visible = false;
            // 
            // pictureBoxFire2
            // 
            this.pictureBoxFire2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxFire2.Image = global::EarthWarNsp.Properties.Resources.fire;
            this.pictureBoxFire2.Location = new System.Drawing.Point(486, 300);
            this.pictureBoxFire2.Name = "pictureBoxFire2";
            this.pictureBoxFire2.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFire2.TabIndex = 21;
            this.pictureBoxFire2.TabStop = false;
            this.pictureBoxFire2.Visible = false;
            // 
            // pictureBoxFire
            // 
            this.pictureBoxFire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxFire.Image = global::EarthWarNsp.Properties.Resources.fire;
            this.pictureBoxFire.Location = new System.Drawing.Point(125, 300);
            this.pictureBoxFire.Name = "pictureBoxFire";
            this.pictureBoxFire.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxFire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFire.TabIndex = 20;
            this.pictureBoxFire.TabStop = false;
            this.pictureBoxFire.Visible = false;
            // 
            // pictureBoxEarthGif
            // 
            this.pictureBoxEarthGif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxEarthGif.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEarthGif.Image = global::EarthWarNsp.Properties.Resources.earth;
            this.pictureBoxEarthGif.Location = new System.Drawing.Point(163, 92);
            this.pictureBoxEarthGif.Name = "pictureBoxEarthGif";
            this.pictureBoxEarthGif.Size = new System.Drawing.Size(700, 700);
            this.pictureBoxEarthGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEarthGif.TabIndex = 0;
            this.pictureBoxEarthGif.TabStop = false;
            // 
            // pictureBoxDayNight
            // 
            this.pictureBoxDayNight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDayNight.Image = global::EarthWarNsp.Properties.Resources.clock;
            this.pictureBoxDayNight.Location = new System.Drawing.Point(500, 429);
            this.pictureBoxDayNight.Name = "pictureBoxDayNight";
            this.pictureBoxDayNight.Size = new System.Drawing.Size(103, 89);
            this.pictureBoxDayNight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDayNight.TabIndex = 4;
            this.pictureBoxDayNight.TabStop = false;
            this.pictureBoxDayNight.Visible = false;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.SystemColors.Info;
            this.buttonAbout.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(57, 21);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(232, 41);
            this.buttonAbout.TabIndex = 24;
            this.buttonAbout.Text = "About game";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Visible = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1034, 951);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.pictureBoxSamllEarth);
            this.Controls.Add(this.pictureBoxDN);
            this.Controls.Add(this.pictureBoxFire3);
            this.Controls.Add(this.pictureBoxFire2);
            this.Controls.Add(this.pictureBoxFire);
            this.Controls.Add(this.labelDivisionsPowerLabel);
            this.Controls.Add(this.labelDivisionPower);
            this.Controls.Add(this.labelDivisions);
            this.Controls.Add(this.dataGridViewDivision);
            this.Controls.Add(this.buttonCreateDivision);
            this.Controls.Add(this.labelChoosenPlatoons);
            this.Controls.Add(this.buttonCreatePlatoon);
            this.Controls.Add(this.labelChoosenSoldiers);
            this.Controls.Add(this.labelPlatoons);
            this.Controls.Add(this.labelSoldiers);
            this.Controls.Add(this.dataGridViewPlatoon);
            this.Controls.Add(this.labelDaysLeft);
            this.Controls.Add(this.buttonStopDay);
            this.Controls.Add(this.dataGridViewSoldier);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.pictureBoxEarthGif);
            this.Controls.Add(this.pictureBoxDayNight);
            this.MaximumSize = new System.Drawing.Size(1050, 990);
            this.MinimumSize = new System.Drawing.Size(1050, 990);
            this.Name = "FormMain";
            this.Text = "EarthWar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoldier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSamllEarth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEarthGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDayNight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEarthGif;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.Timer timerDay;
        private System.Windows.Forms.PictureBox pictureBoxDayNight;
        private System.Windows.Forms.PictureBox pictureBoxDN;
        private System.Windows.Forms.DataGridView dataGridViewSoldier;
        private System.Windows.Forms.Button buttonStopDay;
        private System.Windows.Forms.Label labelDaysLeft;
        private System.Windows.Forms.DataGridView dataGridViewPlatoon;
        private System.Windows.Forms.Label labelSoldiers;
        private System.Windows.Forms.Label labelPlatoons;
        private System.Windows.Forms.Label labelChoosenSoldiers;
        private System.Windows.Forms.Button buttonCreatePlatoon;
        private System.Windows.Forms.Button buttonCreateDivision;
        private System.Windows.Forms.Label labelChoosenPlatoons;
        private System.Windows.Forms.DataGridView dataGridViewDivision;
        private System.Windows.Forms.Label labelDivisions;
        private System.Windows.Forms.Label labelDivisionPower;
        private System.Windows.Forms.Label labelDivisionsPowerLabel;
        private System.Windows.Forms.PictureBox pictureBoxFire;
        private System.Windows.Forms.PictureBox pictureBoxFire2;
        private System.Windows.Forms.PictureBox pictureBoxFire3;
        private System.Windows.Forms.PictureBox pictureBoxSamllEarth;
        private System.Windows.Forms.Button buttonAbout;
    }
}

