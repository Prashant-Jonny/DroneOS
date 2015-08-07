namespace DroneOSClient
{
    partial class CameraFeed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraFeed));
            this.OpenCRVstatus = new System.Windows.Forms.StatusStrip();
            this.CRVstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCRVstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.feedRaw1 = new System.Windows.Forms.PictureBox();
            this.rawFeed1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tblStatus1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblStatus2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feedProc1 = new System.Windows.Forms.PictureBox();
            this.feedRaw2 = new System.Windows.Forms.PictureBox();
            this.feedProc2 = new System.Windows.Forms.PictureBox();
            this.OpenCRVstatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedRaw1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedProc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedRaw2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedProc2)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenCRVstatus
            // 
            this.OpenCRVstatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CRVstatus,
            this.lblCRVstatus});
            this.OpenCRVstatus.Location = new System.Drawing.Point(0, 631);
            this.OpenCRVstatus.Name = "OpenCRVstatus";
            this.OpenCRVstatus.Size = new System.Drawing.Size(1087, 22);
            this.OpenCRVstatus.TabIndex = 1;
            this.OpenCRVstatus.Text = "statusStrip1";
            // 
            // CRVstatus
            // 
            this.CRVstatus.Name = "CRVstatus";
            this.CRVstatus.Size = new System.Drawing.Size(96, 17);
            this.CRVstatus.Text = "OpenCRV Status:";
            // 
            // lblCRVstatus
            // 
            this.lblCRVstatus.Name = "lblCRVstatus";
            this.lblCRVstatus.Size = new System.Drawing.Size(27, 17);
            this.lblCRVstatus.Text = "null";
            // 
            // feedRaw1
            // 
            this.feedRaw1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedRaw1.Image = global::DroneOS.Properties.Resources.no_preview;
            this.feedRaw1.Location = new System.Drawing.Point(12, 36);
            this.feedRaw1.Name = "feedRaw1";
            this.feedRaw1.Size = new System.Drawing.Size(393, 268);
            this.feedRaw1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feedRaw1.TabIndex = 2;
            this.feedRaw1.TabStop = false;
            // 
            // rawFeed1
            // 
            this.rawFeed1.AutoSize = true;
            this.rawFeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rawFeed1.Location = new System.Drawing.Point(12, 9);
            this.rawFeed1.Name = "rawFeed1";
            this.rawFeed1.Size = new System.Drawing.Size(67, 24);
            this.rawFeed1.TabIndex = 6;
            this.rawFeed1.Text = "Raw 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Processed 2:";
            // 
            // tblStatus1
            // 
            this.tblStatus1.ColumnCount = 2;
            this.tblStatus1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatus1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatus1.Location = new System.Drawing.Point(832, 36);
            this.tblStatus1.Name = "tblStatus1";
            this.tblStatus1.RowCount = 5;
            this.tblStatus1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatus1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatus1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatus1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatus1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatus1.Size = new System.Drawing.Size(200, 141);
            this.tblStatus1.TabIndex = 10;
            // 
            // tblStatus2
            // 
            this.tblStatus2.ColumnCount = 2;
            this.tblStatus2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatus2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatus2.Location = new System.Drawing.Point(832, 345);
            this.tblStatus2.Name = "tblStatus2";
            this.tblStatus2.RowCount = 5;
            this.tblStatus2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatus2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatus2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatus2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatus2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblStatus2.Size = new System.Drawing.Size(200, 139);
            this.tblStatus2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Processed 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Raw 2:";
            // 
            // feedProc1
            // 
            this.feedProc1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.feedProc1.Image = global::DroneOS.Properties.Resources.no_preview;
            this.feedProc1.Location = new System.Drawing.Point(422, 36);
            this.feedProc1.Name = "feedProc1";
            this.feedProc1.Size = new System.Drawing.Size(393, 268);
            this.feedProc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feedProc1.TabIndex = 12;
            this.feedProc1.TabStop = false;
            // 
            // feedRaw2
            // 
            this.feedRaw2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.feedRaw2.Image = global::DroneOS.Properties.Resources.no_preview;
            this.feedRaw2.Location = new System.Drawing.Point(12, 345);
            this.feedRaw2.Name = "feedRaw2";
            this.feedRaw2.Size = new System.Drawing.Size(393, 268);
            this.feedRaw2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feedRaw2.TabIndex = 13;
            this.feedRaw2.TabStop = false;
            // 
            // feedProc2
            // 
            this.feedProc2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.feedProc2.Image = global::DroneOS.Properties.Resources.no_preview;
            this.feedProc2.Location = new System.Drawing.Point(422, 345);
            this.feedProc2.Name = "feedProc2";
            this.feedProc2.Size = new System.Drawing.Size(393, 268);
            this.feedProc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.feedProc2.TabIndex = 14;
            this.feedProc2.TabStop = false;
            // 
            // CameraFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 653);
            this.Controls.Add(this.feedProc2);
            this.Controls.Add(this.feedRaw2);
            this.Controls.Add(this.feedProc1);
            this.Controls.Add(this.tblStatus2);
            this.Controls.Add(this.tblStatus1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rawFeed1);
            this.Controls.Add(this.feedRaw1);
            this.Controls.Add(this.OpenCRVstatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraFeed";
            this.Text = "Camera Feeds";
            this.OpenCRVstatus.ResumeLayout(false);
            this.OpenCRVstatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedRaw1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedProc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedRaw2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedProc2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip OpenCRVstatus;
        private System.Windows.Forms.ToolStripStatusLabel CRVstatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCRVstatus;
        private System.Windows.Forms.PictureBox feedRaw1;
        private System.Windows.Forms.Label rawFeed1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tblStatus1;
        private System.Windows.Forms.TableLayoutPanel tblStatus2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox feedProc1;
        private System.Windows.Forms.PictureBox feedRaw2;
        private System.Windows.Forms.PictureBox feedProc2;
    }
}