using System.Windows.Forms;
namespace DroneOSServer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.debugBox = new System.Windows.Forms.RichTextBox();
            this.txtConsoleInput = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.droneOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenMission = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveMission = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveMissionAs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraFeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iOPinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMissionPlan = new System.Windows.Forms.OpenFileDialog();
            this.saveMissionPlan = new System.Windows.Forms.SaveFileDialog();
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
            this.MotorControlsGroup = new System.Windows.Forms.GroupBox();
            this.btnRollRight = new System.Windows.Forms.Button();
            this.btnRollLeft = new System.Windows.Forms.Button();
            this.OpsGroup = new System.Windows.Forms.GroupBox();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.eventLog = new System.Diagnostics.EventLog();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.mainStatusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.MotorControlsGroup.SuspendLayout();
            this.OpsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).BeginInit();
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
            this.debugBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.debugBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugBox.Location = new System.Drawing.Point(12, 33);
            this.debugBox.Name = "debugBox";
            this.debugBox.ReadOnly = true;
            this.debugBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.debugBox.Size = new System.Drawing.Size(449, 394);
            this.debugBox.TabIndex = 2;
            this.debugBox.Text = "";
            this.debugBox.TextChanged += new System.EventHandler(this.debugBox_TextChanged);
            // 
            // txtConsoleInput
            // 
            this.txtConsoleInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtConsoleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsoleInput.Location = new System.Drawing.Point(12, 433);
            this.txtConsoleInput.Name = "txtConsoleInput";
            this.txtConsoleInput.Size = new System.Drawing.Size(449, 22);
            this.txtConsoleInput.TabIndex = 1;
            this.txtConsoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.executeCommand);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.droneOSToolStripMenuItem,
            this.viewToolStripMenuItem,
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
            this.newMissionToolStripMenuItem,
            this.btnOpenMission,
            this.btnSaveMission,
            this.btnSaveMissionAs,
            this.btnExit});
            this.droneOSToolStripMenuItem.Name = "droneOSToolStripMenuItem";
            this.droneOSToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.droneOSToolStripMenuItem.Text = "DroneOS";
            // 
            // newMissionToolStripMenuItem
            // 
            this.newMissionToolStripMenuItem.Name = "newMissionToolStripMenuItem";
            this.newMissionToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.newMissionToolStripMenuItem.Text = "New Mission";
            // 
            // btnOpenMission
            // 
            this.btnOpenMission.Name = "btnOpenMission";
            this.btnOpenMission.ShortcutKeyDisplayString = "";
            this.btnOpenMission.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpenMission.Size = new System.Drawing.Size(247, 22);
            this.btnOpenMission.Text = "Open Mission Plan";
            this.btnOpenMission.Click += new System.EventHandler(this.openMissionDialog);
            // 
            // btnSaveMission
            // 
            this.btnSaveMission.Name = "btnSaveMission";
            this.btnSaveMission.ShortcutKeyDisplayString = "";
            this.btnSaveMission.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSaveMission.Size = new System.Drawing.Size(247, 22);
            this.btnSaveMission.Text = "Save Mission Plan";
            // 
            // btnSaveMissionAs
            // 
            this.btnSaveMissionAs.Name = "btnSaveMissionAs";
            this.btnSaveMissionAs.ShortcutKeyDisplayString = "";
            this.btnSaveMissionAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.btnSaveMissionAs.Size = new System.Drawing.Size(247, 22);
            this.btnSaveMissionAs.Text = "Save Mission Plan As";
            this.btnSaveMissionAs.Click += new System.EventHandler(this.saveMissionDialog);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.btnExit.Size = new System.Drawing.Size(247, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.mainExit);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraFeedToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.iOPinsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // cameraFeedToolStripMenuItem
            // 
            this.cameraFeedToolStripMenuItem.Name = "cameraFeedToolStripMenuItem";
            this.cameraFeedToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cameraFeedToolStripMenuItem.Text = "Camera Feed";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // iOPinsToolStripMenuItem
            // 
            this.iOPinsToolStripMenuItem.Name = "iOPinsToolStripMenuItem";
            this.iOPinsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.iOPinsToolStripMenuItem.Text = "I/O Pins";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.btnAbout);
            // 
            // openMissionPlan
            // 
            this.openMissionPlan.Filter = "DroneOS Mission|*.msn";
            // 
            // saveMissionPlan
            // 
            this.saveMissionPlan.Filter = "DroneOS Mission|*.msn";
            // 
            // btnSurface
            // 
            this.btnSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurface.Location = new System.Drawing.Point(174, 34);
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
            this.btnStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartStop.Location = new System.Drawing.Point(12, 34);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 30);
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.toggleStartStop);
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Location = new System.Drawing.Point(93, 34);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(75, 30);
            this.btnManual.TabIndex = 5;
            this.btnManual.Text = "Auto";
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
            this.btnRaise.Click += new System.EventHandler(this.btnRaise_Click);
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
            this.btnDive.Click += new System.EventHandler(this.btnDive_Click);
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(93, 122);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 30);
            this.btnForward.TabIndex = 8;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnRotateR
            // 
            this.btnRotateR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateR.Location = new System.Drawing.Point(174, 139);
            this.btnRotateR.Name = "btnRotateR";
            this.btnRotateR.Size = new System.Drawing.Size(75, 30);
            this.btnRotateR.TabIndex = 9;
            this.btnRotateR.Text = "Rotate R";
            this.btnRotateR.UseVisualStyleBackColor = true;
            this.btnRotateR.Click += new System.EventHandler(this.btnRotateR_Click);
            // 
            // btnRotateL
            // 
            this.btnRotateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotateL.Location = new System.Drawing.Point(12, 139);
            this.btnRotateL.Name = "btnRotateL";
            this.btnRotateL.Size = new System.Drawing.Size(75, 30);
            this.btnRotateL.TabIndex = 10;
            this.btnRotateL.Text = "Rotate L";
            this.btnRotateL.UseVisualStyleBackColor = true;
            this.btnRotateL.Click += new System.EventHandler(this.btnRotateL_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.Location = new System.Drawing.Point(93, 158);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(75, 30);
            this.btnReverse.TabIndex = 11;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
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
            this.btnTranL.Click += new System.EventHandler(this.btnTranL_Click);
            // 
            // btnTranR
            // 
            this.btnTranR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranR.Location = new System.Drawing.Point(174, 36);
            this.btnTranR.Name = "btnTranR";
            this.btnTranR.Size = new System.Drawing.Size(75, 30);
            this.btnTranR.TabIndex = 13;
            this.btnTranR.Text = "Trans R";
            this.btnTranR.UseVisualStyleBackColor = true;
            this.btnTranR.Click += new System.EventHandler(this.btnTranR_Click);
            // 
            // MotorControlsGroup
            // 
            this.MotorControlsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MotorControlsGroup.Controls.Add(this.btnRollRight);
            this.MotorControlsGroup.Controls.Add(this.btnRollLeft);
            this.MotorControlsGroup.Controls.Add(this.btnTranR);
            this.MotorControlsGroup.Controls.Add(this.btnTranL);
            this.MotorControlsGroup.Controls.Add(this.btnReverse);
            this.MotorControlsGroup.Controls.Add(this.btnRotateL);
            this.MotorControlsGroup.Controls.Add(this.btnForward);
            this.MotorControlsGroup.Controls.Add(this.btnDive);
            this.MotorControlsGroup.Controls.Add(this.btnRaise);
            this.MotorControlsGroup.Controls.Add(this.btnRotateR);
            this.MotorControlsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorControlsGroup.Location = new System.Drawing.Point(708, 27);
            this.MotorControlsGroup.Name = "MotorControlsGroup";
            this.MotorControlsGroup.Size = new System.Drawing.Size(259, 200);
            this.MotorControlsGroup.TabIndex = 14;
            this.MotorControlsGroup.TabStop = false;
            this.MotorControlsGroup.Text = "Motor Controls";
            // 
            // btnRollRight
            // 
            this.btnRollRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollRight.Location = new System.Drawing.Point(174, 88);
            this.btnRollRight.Name = "btnRollRight";
            this.btnRollRight.Size = new System.Drawing.Size(75, 30);
            this.btnRollRight.TabIndex = 15;
            this.btnRollRight.Text = "Roll R";
            this.btnRollRight.UseVisualStyleBackColor = true;
            this.btnRollRight.Click += new System.EventHandler(this.btnRollRight_Click);
            // 
            // btnRollLeft
            // 
            this.btnRollLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollLeft.Location = new System.Drawing.Point(12, 88);
            this.btnRollLeft.Name = "btnRollLeft";
            this.btnRollLeft.Size = new System.Drawing.Size(75, 30);
            this.btnRollLeft.TabIndex = 14;
            this.btnRollLeft.Text = "Roll L";
            this.btnRollLeft.UseVisualStyleBackColor = true;
            this.btnRollLeft.Click += new System.EventHandler(this.btnRollLeft_Click);
            // 
            // OpsGroup
            // 
            this.OpsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpsGroup.Controls.Add(this.btnShutdown);
            this.OpsGroup.Controls.Add(this.btnManual);
            this.OpsGroup.Controls.Add(this.btnSurface);
            this.OpsGroup.Controls.Add(this.btnStartStop);
            this.OpsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpsGroup.Location = new System.Drawing.Point(708, 323);
            this.OpsGroup.Name = "OpsGroup";
            this.OpsGroup.Size = new System.Drawing.Size(259, 132);
            this.OpsGroup.TabIndex = 15;
            this.OpsGroup.TabStop = false;
            this.OpsGroup.Text = "Operational Status";
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackColor = System.Drawing.Color.Red;
            this.btnShutdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShutdown.ForeColor = System.Drawing.Color.White;
            this.btnShutdown.Location = new System.Drawing.Point(12, 70);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(237, 46);
            this.btnShutdown.TabIndex = 6;
            this.btnShutdown.Text = "Stop";
            this.btnShutdown.UseVisualStyleBackColor = false;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_click);
            // 
            // eventLog
            // 
            this.eventLog.SynchronizingObject = this;
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 490);
            this.Controls.Add(this.OpsGroup);
            this.Controls.Add(this.MotorControlsGroup);
            this.Controls.Add(this.txtConsoleInput);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(995, 528);
            this.Name = "MainForm";
            this.Text = "DroneOS Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.exitProgram);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.MotorControlsGroup.ResumeLayout(false);
            this.OpsGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblServerStatus;
        private System.Windows.Forms.RichTextBox debugBox;
        private System.Windows.Forms.TextBox txtConsoleInput;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem droneOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpenMission;
        private System.Windows.Forms.ToolStripMenuItem btnSaveMissionAs;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private OpenFileDialog openMissionPlan;
        private SaveFileDialog saveMissionPlan;
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
        private GroupBox MotorControlsGroup;
        private GroupBox OpsGroup;
        private ToolStripMenuItem btnSaveMission;
        private System.Diagnostics.EventLog eventLog;
        private Button btnShutdown;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem iOPinsToolStripMenuItem;
        private Timer mainTimer;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private Button btnRollLeft;
        private Button btnRollRight;
        private ToolStripMenuItem newMissionToolStripMenuItem;
    }
}