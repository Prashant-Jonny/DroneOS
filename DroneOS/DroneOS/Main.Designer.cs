using System.Windows.Forms;
namespace DroneOSClient
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.debugBox = new System.Windows.Forms.RichTextBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.droneOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveFlightAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraFeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.processedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFlightPlan = new System.Windows.Forms.OpenFileDialog();
            this.saveFlightPlan = new System.Windows.Forms.SaveFileDialog();
            this.btnSurface = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnRaise = new System.Windows.Forms.Button();
            this.btnDive = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnRotateR = new System.Windows.Forms.Button();
            this.btnRotateL = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnTranL = new System.Windows.Forms.Button();
            this.btnTranR = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveFlight = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblServerStatus});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 468);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(979, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(77, 17);
            this.lblServerStatus.Text = "Server Status:";
            // 
            // debugBox
            // 
            this.debugBox.Location = new System.Drawing.Point(12, 33);
            this.debugBox.Name = "debugBox";
            this.debugBox.ReadOnly = true;
            this.debugBox.Size = new System.Drawing.Size(449, 394);
            this.debugBox.TabIndex = 2;
            this.debugBox.Text = "";
            // 
            // txtConsole
            // 
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.Location = new System.Drawing.Point(12, 433);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(449, 22);
            this.txtConsole.TabIndex = 1;
            this.txtConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.executeCommand);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.droneOSToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(979, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // droneOSToolStripMenuItem
            // 
            this.droneOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFlight,
            this.btnSaveFlight,
            this.btnSaveFlightAs,
            this.btnExit});
            this.droneOSToolStripMenuItem.Name = "droneOSToolStripMenuItem";
            this.droneOSToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.droneOSToolStripMenuItem.Text = "DroneOS";
            // 
            // btnOpenFlight
            // 
            this.btnOpenFlight.Name = "btnOpenFlight";
            this.btnOpenFlight.ShortcutKeyDisplayString = "";
            this.btnOpenFlight.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpenFlight.Size = new System.Drawing.Size(236, 22);
            this.btnOpenFlight.Text = "Open Flight Plan";
            this.btnOpenFlight.Click += new System.EventHandler(this.openFlightDialog);
            // 
            // btnSaveFlightAs
            // 
            this.btnSaveFlightAs.Name = "btnSaveFlightAs";
            this.btnSaveFlightAs.ShortcutKeyDisplayString = "";
            this.btnSaveFlightAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.btnSaveFlightAs.Size = new System.Drawing.Size(236, 22);
            this.btnSaveFlightAs.Text = "Save Flight Plan As";
            this.btnSaveFlightAs.Click += new System.EventHandler(this.saveFlightDialog);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnExit.Size = new System.Drawing.Size(236, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.mainExit);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraFeedToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // cameraFeedToolStripMenuItem
            // 
            this.cameraFeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawToolStripMenuItem,
            this.rawToolStripMenuItem1,
            this.processedToolStripMenuItem,
            this.processedToolStripMenuItem1});
            this.cameraFeedToolStripMenuItem.Name = "cameraFeedToolStripMenuItem";
            this.cameraFeedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cameraFeedToolStripMenuItem.Text = "Camera Feed";
            // 
            // rawToolStripMenuItem
            // 
            this.rawToolStripMenuItem.Name = "rawToolStripMenuItem";
            this.rawToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rawToolStripMenuItem.Text = "1 Raw";
            // 
            // rawToolStripMenuItem1
            // 
            this.rawToolStripMenuItem1.Name = "rawToolStripMenuItem1";
            this.rawToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.rawToolStripMenuItem1.Text = "2 Raw";
            // 
            // processedToolStripMenuItem
            // 
            this.processedToolStripMenuItem.Name = "processedToolStripMenuItem";
            this.processedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.processedToolStripMenuItem.Text = "1 Processed";
            // 
            // processedToolStripMenuItem1
            // 
            this.processedToolStripMenuItem1.Name = "processedToolStripMenuItem1";
            this.processedToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.processedToolStripMenuItem1.Text = "2 Processed";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.btnAbout);
            // 
            // openFlightPlan
            // 
            this.openFlightPlan.FileName = "openFileDialog1";
            this.openFlightPlan.Filter = "DroneOS Flight|*.pln";
            // 
            // saveFlightPlan
            // 
            this.saveFlightPlan.Filter = "DroneOS Flight|*.pln";
            // 
            // btnSurface
            // 
            this.btnSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurface.Location = new System.Drawing.Point(168, 19);
            this.btnSurface.Name = "btnSurface";
            this.btnSurface.Size = new System.Drawing.Size(75, 30);
            this.btnSurface.TabIndex = 3;
            this.btnSurface.Text = "Surface";
            this.btnSurface.UseVisualStyleBackColor = true;
            // 
            // btnStartStop
            // 
            this.btnStartStop.BackColor = System.Drawing.Color.PaleGreen;
            this.btnStartStop.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(6, 64);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(237, 63);
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.toggleStartStop);
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Location = new System.Drawing.Point(6, 19);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(75, 30);
            this.btnManual.TabIndex = 5;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.switchManAuto);
            // 
            // btnRaise
            // 
            this.btnRaise.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaise.Location = new System.Drawing.Point(93, 19);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(75, 30);
            this.btnRaise.TabIndex = 6;
            this.btnRaise.Text = "Rise";
            this.btnRaise.UseVisualStyleBackColor = true;
            // 
            // btnDive
            // 
            this.btnDive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDive.Location = new System.Drawing.Point(93, 55);
            this.btnDive.Name = "btnDive";
            this.btnDive.Size = new System.Drawing.Size(75, 30);
            this.btnDive.TabIndex = 7;
            this.btnDive.Text = "Dive";
            this.btnDive.UseVisualStyleBackColor = true;
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(93, 108);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 30);
            this.btnForward.TabIndex = 8;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnRotateR
            // 
            this.btnRotateR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateR.Location = new System.Drawing.Point(174, 125);
            this.btnRotateR.Name = "btnRotateR";
            this.btnRotateR.Size = new System.Drawing.Size(75, 30);
            this.btnRotateR.TabIndex = 9;
            this.btnRotateR.Text = "Rotate R";
            this.btnRotateR.UseVisualStyleBackColor = true;
            // 
            // btnRotateL
            // 
            this.btnRotateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateL.Location = new System.Drawing.Point(14, 125);
            this.btnRotateL.Name = "btnRotateL";
            this.btnRotateL.Size = new System.Drawing.Size(75, 30);
            this.btnRotateL.TabIndex = 10;
            this.btnRotateL.Text = "Rotate L";
            this.btnRotateL.UseVisualStyleBackColor = true;
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.Location = new System.Drawing.Point(93, 144);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 30);
            this.btnReverse.TabIndex = 11;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            // 
            // btnTranL
            // 
            this.btnTranL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranL.Location = new System.Drawing.Point(12, 36);
            this.btnTranL.Name = "btnTranL";
            this.btnTranL.Size = new System.Drawing.Size(75, 30);
            this.btnTranL.TabIndex = 12;
            this.btnTranL.Text = "Trans L";
            this.btnTranL.UseVisualStyleBackColor = true;
            // 
            // btnTranR
            // 
            this.btnTranR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranR.Location = new System.Drawing.Point(172, 36);
            this.btnTranR.Name = "btnTranR";
            this.btnTranR.Size = new System.Drawing.Size(75, 30);
            this.btnTranR.TabIndex = 13;
            this.btnTranR.Text = "Trans R";
            this.btnTranR.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTranR);
            this.groupBox1.Controls.Add(this.btnTranL);
            this.groupBox1.Controls.Add(this.btnReverse);
            this.groupBox1.Controls.Add(this.btnRotateL);
            this.groupBox1.Controls.Add(this.btnForward);
            this.groupBox1.Controls.Add(this.btnDive);
            this.groupBox1.Controls.Add(this.btnRaise);
            this.groupBox1.Controls.Add(this.btnRotateR);
            this.groupBox1.Location = new System.Drawing.Point(708, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 179);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnManual);
            this.groupBox2.Controls.Add(this.btnSurface);
            this.groupBox2.Controls.Add(this.btnStartStop);
            this.groupBox2.Location = new System.Drawing.Point(708, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 149);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnSaveFlight
            // 
            this.btnSaveFlight.Name = "btnSaveFlight";
            this.btnSaveFlight.ShortcutKeyDisplayString = "";
            this.btnSaveFlight.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSaveFlight.Size = new System.Drawing.Size(236, 22);
            this.btnSaveFlight.Text = "Save Flight Plan";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.Text = "DroneOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitProgram);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblServerStatus;
        private System.Windows.Forms.RichTextBox debugBox;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem droneOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpenFlight;
        private System.Windows.Forms.ToolStripMenuItem btnSaveFlightAs;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private OpenFileDialog openFlightPlan;
        private SaveFileDialog saveFlightPlan;
        private Button btnSurface;
        private Button btnStartStop;
        private Button btnManual;
        private Button btnRaise;
        private Button btnDive;
        private Button btnForward;
        private Button btnRotateR;
        private Button btnRotateL;
        private Button btnReverse;
        private Button btnTranL;
        private Button btnTranR;
        private ToolStripMenuItem cameraFeedToolStripMenuItem;
        private ToolStripMenuItem rawToolStripMenuItem;
        private ToolStripMenuItem rawToolStripMenuItem1;
        private ToolStripMenuItem processedToolStripMenuItem;
        private ToolStripMenuItem processedToolStripMenuItem1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStripMenuItem btnSaveFlight;
    }
}