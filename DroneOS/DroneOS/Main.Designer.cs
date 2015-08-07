using System.Windows.Forms;
namespace DroneOSClient
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblServerStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.debugBox = new System.Windows.Forms.RichTextBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.droneOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFlightPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFlightPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFlightPlan = new System.Windows.Forms.OpenFileDialog();
            this.saveFlightPlan = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.mainStatusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
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
            this.debugBox.Size = new System.Drawing.Size(392, 394);
            this.debugBox.TabIndex = 2;
            this.debugBox.Text = "";
            // 
            // txtConsole
            // 
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.Location = new System.Drawing.Point(12, 433);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(392, 22);
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
            this.openFlightPlanToolStripMenuItem,
            this.saveFlightPlanToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.droneOSToolStripMenuItem.Name = "droneOSToolStripMenuItem";
            this.droneOSToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.droneOSToolStripMenuItem.Text = "DroneOS";
            // 
            // openFlightPlanToolStripMenuItem
            // 
            this.openFlightPlanToolStripMenuItem.Name = "openFlightPlanToolStripMenuItem";
            this.openFlightPlanToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openFlightPlanToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openFlightPlanToolStripMenuItem.Text = "Open Flight Plan";
            this.openFlightPlanToolStripMenuItem.Click += new System.EventHandler(this.openFlightDialog);
            // 
            // saveFlightPlanToolStripMenuItem
            // 
            this.saveFlightPlanToolStripMenuItem.Name = "saveFlightPlanToolStripMenuItem";
            this.saveFlightPlanToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.saveFlightPlanToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveFlightPlanToolStripMenuItem.Text = "Save Flight Plan";
            this.saveFlightPlanToolStripMenuItem.Click += new System.EventHandler(this.saveFlightDialog);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.mainExit);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(881, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Surface";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(729, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 63);
            this.button2.TabIndex = 4;
            this.button2.Text = "Shutdown";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Location = new System.Drawing.Point(729, 348);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(75, 30);
            this.btnManual.TabIndex = 5;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 490);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.debugBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "DroneOS";
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem openFlightPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFlightPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem connectionToolStripMenuItem;
        private OpenFileDialog openFlightPlan;
        private SaveFileDialog saveFlightPlan;
        private Button button1;
        private Button button2;
        private Button btnManual;
    }
}