namespace Project_DAQ
{
    partial class DataLogging_DAQ_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataLogging_DAQ_App));
            this.btnGetTmp36data = new System.Windows.Forms.Button();
            this.txtTemp36Data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempThermistor = new System.Windows.Forms.TextBox();
            this.btnGetTempThermistor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLightsensor = new System.Windows.Forms.TextBox();
            this.btnGetLightsensor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGreenColor = new System.Windows.Forms.TextBox();
            this.txtRedColor = new System.Windows.Forms.TextBox();
            this.chkLed = new System.Windows.Forms.CheckBox();
            this.tmrLEDStatus = new System.Windows.Forms.Timer(this.components);
            this.txtStatusTmp36 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatusThermistor = new System.Windows.Forms.TextBox();
            this.txtStatusLightSensor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeIntervalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.picTmp36 = new System.Windows.Forms.PictureBox();
            this.picThermistor = new System.Windows.Forms.PictureBox();
            this.picLightSensor = new System.Windows.Forms.PictureBox();
            this.btnGreenlight = new System.Windows.Forms.Button();
            this.txtTimeInterval = new System.Windows.Forms.TextBox();
            this.dgvSensors = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTmp36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThermistor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetTmp36data
            // 
            this.btnGetTmp36data.Location = new System.Drawing.Point(124, 58);
            this.btnGetTmp36data.Name = "btnGetTmp36data";
            this.btnGetTmp36data.Size = new System.Drawing.Size(75, 23);
            this.btnGetTmp36data.TabIndex = 0;
            this.btnGetTmp36data.Text = "Get data";
            this.btnGetTmp36data.UseVisualStyleBackColor = true;
            this.btnGetTmp36data.Click += new System.EventHandler(this.btnGetTmp36data_Click);
            // 
            // txtTemp36Data
            // 
            this.txtTemp36Data.Location = new System.Drawing.Point(22, 61);
            this.txtTemp36Data.Name = "txtTemp36Data";
            this.txtTemp36Data.Size = new System.Drawing.Size(69, 20);
            this.txtTemp36Data.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temperature value TMP36:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Temperature value Thermistor:";
            // 
            // txtTempThermistor
            // 
            this.txtTempThermistor.Location = new System.Drawing.Point(22, 128);
            this.txtTempThermistor.Name = "txtTempThermistor";
            this.txtTempThermistor.Size = new System.Drawing.Size(69, 20);
            this.txtTempThermistor.TabIndex = 4;
            // 
            // btnGetTempThermistor
            // 
            this.btnGetTempThermistor.Location = new System.Drawing.Point(124, 128);
            this.btnGetTempThermistor.Name = "btnGetTempThermistor";
            this.btnGetTempThermistor.Size = new System.Drawing.Size(75, 23);
            this.btnGetTempThermistor.TabIndex = 5;
            this.btnGetTempThermistor.Text = "Get data";
            this.btnGetTempThermistor.UseVisualStyleBackColor = true;
            this.btnGetTempThermistor.Click += new System.EventHandler(this.btnGetTempThermistor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lightsensor value:";
            // 
            // txtLightsensor
            // 
            this.txtLightsensor.Location = new System.Drawing.Point(22, 203);
            this.txtLightsensor.Name = "txtLightsensor";
            this.txtLightsensor.Size = new System.Drawing.Size(69, 20);
            this.txtLightsensor.TabIndex = 7;
            // 
            // btnGetLightsensor
            // 
            this.btnGetLightsensor.Location = new System.Drawing.Point(124, 203);
            this.btnGetLightsensor.Name = "btnGetLightsensor";
            this.btnGetLightsensor.Size = new System.Drawing.Size(75, 23);
            this.btnGetLightsensor.TabIndex = 8;
            this.btnGetLightsensor.Text = "Get data";
            this.btnGetLightsensor.UseVisualStyleBackColor = true;
            this.btnGetLightsensor.Click += new System.EventHandler(this.btnGetLightsensor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "C°";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "C°";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Turn on Red light";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtGreenColor
            // 
            this.txtGreenColor.BackColor = System.Drawing.Color.Green;
            this.txtGreenColor.Location = new System.Drawing.Point(176, 274);
            this.txtGreenColor.Name = "txtGreenColor";
            this.txtGreenColor.ReadOnly = true;
            this.txtGreenColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtGreenColor.Size = new System.Drawing.Size(20, 20);
            this.txtGreenColor.TabIndex = 13;
            // 
            // txtRedColor
            // 
            this.txtRedColor.BackColor = System.Drawing.Color.Red;
            this.txtRedColor.Location = new System.Drawing.Point(176, 315);
            this.txtRedColor.Name = "txtRedColor";
            this.txtRedColor.ReadOnly = true;
            this.txtRedColor.Size = new System.Drawing.Size(20, 20);
            this.txtRedColor.TabIndex = 14;
            // 
            // chkLed
            // 
            this.chkLed.AutoSize = true;
            this.chkLed.Location = new System.Drawing.Point(24, 248);
            this.chkLed.Name = "chkLed";
            this.chkLed.Size = new System.Drawing.Size(132, 17);
            this.chkLed.TabIndex = 15;
            this.chkLed.Text = "Manual control of LED";
            this.chkLed.UseVisualStyleBackColor = true;
            this.chkLed.CheckedChanged += new System.EventHandler(this.chkLed_CheckedChanged);
            // 
            // tmrLEDStatus
            // 
            this.tmrLEDStatus.Enabled = true;
            this.tmrLEDStatus.Interval = 1;
            this.tmrLEDStatus.Tick += new System.EventHandler(this.tmrLEDStatus_Tick);
            // 
            // txtStatusTmp36
            // 
            this.txtStatusTmp36.Location = new System.Drawing.Point(205, 61);
            this.txtStatusTmp36.Name = "txtStatusTmp36";
            this.txtStatusTmp36.ReadOnly = true;
            this.txtStatusTmp36.Size = new System.Drawing.Size(45, 20);
            this.txtStatusTmp36.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Status:";
            // 
            // txtStatusThermistor
            // 
            this.txtStatusThermistor.Location = new System.Drawing.Point(203, 131);
            this.txtStatusThermistor.Name = "txtStatusThermistor";
            this.txtStatusThermistor.ReadOnly = true;
            this.txtStatusThermistor.Size = new System.Drawing.Size(45, 20);
            this.txtStatusThermistor.TabIndex = 18;
            // 
            // txtStatusLightSensor
            // 
            this.txtStatusLightSensor.Location = new System.Drawing.Point(203, 206);
            this.txtStatusLightSensor.Name = "txtStatusLightSensor";
            this.txtStatusLightSensor.ReadOnly = true;
            this.txtStatusLightSensor.Size = new System.Drawing.Size(45, 20);
            this.txtStatusLightSensor.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Status:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.infoToolStripMenuItem.Text = "Info about the program";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeIntervalToolStripMenuItem,
            this.funModeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // timeIntervalToolStripMenuItem
            // 
            this.timeIntervalToolStripMenuItem.Name = "timeIntervalToolStripMenuItem";
            this.timeIntervalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.timeIntervalToolStripMenuItem.Text = "Time Interval";
            this.timeIntervalToolStripMenuItem.Click += new System.EventHandler(this.timeIntervalToolStripMenuItem_Click_1);
            // 
            // funModeToolStripMenuItem
            // 
            this.funModeToolStripMenuItem.Name = "funModeToolStripMenuItem";
            this.funModeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funModeToolStripMenuItem.Text = "Fun Mode";
            this.funModeToolStripMenuItem.Click += new System.EventHandler(this.funModeToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Current time interval to collect data:";
            // 
            // picTmp36
            // 
            this.picTmp36.Image = ((System.Drawing.Image)(resources.GetObject("picTmp36.Image")));
            this.picTmp36.Location = new System.Drawing.Point(256, 29);
            this.picTmp36.Name = "picTmp36";
            this.picTmp36.Size = new System.Drawing.Size(100, 80);
            this.picTmp36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTmp36.TabIndex = 26;
            this.picTmp36.TabStop = false;
            // 
            // picThermistor
            // 
            this.picThermistor.Image = ((System.Drawing.Image)(resources.GetObject("picThermistor.Image")));
            this.picThermistor.Location = new System.Drawing.Point(256, 112);
            this.picThermistor.Name = "picThermistor";
            this.picThermistor.Size = new System.Drawing.Size(100, 85);
            this.picThermistor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThermistor.TabIndex = 27;
            this.picThermistor.TabStop = false;
            // 
            // picLightSensor
            // 
            this.picLightSensor.Image = ((System.Drawing.Image)(resources.GetObject("picLightSensor.Image")));
            this.picLightSensor.Location = new System.Drawing.Point(256, 206);
            this.picLightSensor.Name = "picLightSensor";
            this.picLightSensor.Size = new System.Drawing.Size(100, 80);
            this.picLightSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLightSensor.TabIndex = 28;
            this.picLightSensor.TabStop = false;
            // 
            // btnGreenlight
            // 
            this.btnGreenlight.Location = new System.Drawing.Point(24, 271);
            this.btnGreenlight.Name = "btnGreenlight";
            this.btnGreenlight.Size = new System.Drawing.Size(146, 23);
            this.btnGreenlight.TabIndex = 11;
            this.btnGreenlight.Text = "Turn on Green light";
            this.btnGreenlight.UseVisualStyleBackColor = true;
            this.btnGreenlight.Click += new System.EventHandler(this.btnGreenlight_Click);
            // 
            // txtTimeInterval
            // 
            this.txtTimeInterval.Location = new System.Drawing.Point(504, 42);
            this.txtTimeInterval.Name = "txtTimeInterval";
            this.txtTimeInterval.ReadOnly = true;
            this.txtTimeInterval.Size = new System.Drawing.Size(43, 20);
            this.txtTimeInterval.TabIndex = 29;
            // 
            // dgvSensors
            // 
            this.dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensors.Location = new System.Drawing.Point(377, 102);
            this.dgvSensors.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSensors.Name = "dgvSensors";
            this.dgvSensors.RowTemplate.Height = 24;
            this.dgvSensors.Size = new System.Drawing.Size(254, 273);
            this.dgvSensors.TabIndex = 127;
            this.dgvSensors.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSensors_CellMouseLeave);
            this.dgvSensors.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSensors_CellMouseMove);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 128;
            this.label10.Text = "Datagrid view for viewing data:";
            // 
            // DataLogging_DAQ_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 386);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvSensors);
            this.Controls.Add(this.txtTimeInterval);
            this.Controls.Add(this.picLightSensor);
            this.Controls.Add(this.picThermistor);
            this.Controls.Add(this.picTmp36);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStatusLightSensor);
            this.Controls.Add(this.txtStatusThermistor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatusTmp36);
            this.Controls.Add(this.chkLed);
            this.Controls.Add(this.txtRedColor);
            this.Controls.Add(this.txtGreenColor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGreenlight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGetLightsensor);
            this.Controls.Add(this.txtLightsensor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetTempThermistor);
            this.Controls.Add(this.txtTempThermistor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemp36Data);
            this.Controls.Add(this.btnGetTmp36data);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataLogging_DAQ_App";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DataLogging_DAQ_App_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTmp36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThermistor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetTmp36data;
        private System.Windows.Forms.TextBox txtTemp36Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTempThermistor;
        private System.Windows.Forms.Button btnGetTempThermistor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLightsensor;
        private System.Windows.Forms.Button btnGetLightsensor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGreenColor;
        private System.Windows.Forms.TextBox txtRedColor;
        private System.Windows.Forms.CheckBox chkLed;
        private System.Windows.Forms.Timer tmrLEDStatus;
        private System.Windows.Forms.TextBox txtStatusTmp36;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatusThermistor;
        private System.Windows.Forms.TextBox txtStatusLightSensor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picTmp36;
        private System.Windows.Forms.PictureBox picThermistor;
        private System.Windows.Forms.PictureBox picLightSensor;
        private System.Windows.Forms.Button btnGreenlight;
        private System.Windows.Forms.TextBox txtTimeInterval;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeIntervalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funModeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSensors;
        private System.Windows.Forms.Label label10;
    }
}

