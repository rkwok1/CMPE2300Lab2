namespace CMPE2300Lab2
{
    partial class UI_MainForm_Installotron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_MainForm_Installotron));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.UI_ToolStrip_LoadFile = new System.Windows.Forms.ToolStripButton();
            this.UI_ToolStrip_Analyze = new System.Windows.Forms.ToolStripButton();
            this.UI_ToolStrip_Algorithm = new System.Windows.Forms.ToolStripComboBox();
            this.UI_ToolStrip_SelectedView = new System.Windows.Forms.ToolStripComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.UI_StatusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.UI_StatusStrip_PackagesLoaded = new System.Windows.Forms.ToolStripStatusLabel();
            this.UI_StatusStrip_PackagesInstallable = new System.Windows.Forms.ToolStripStatusLabel();
            this.UI_StatusStrip_PackagesUninstallable = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.UI_StatusStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UI_ToolStrip_LoadFile,
            this.UI_ToolStrip_Analyze,
            this.UI_ToolStrip_Algorithm,
            this.UI_ToolStrip_SelectedView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(898, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // UI_ToolStrip_LoadFile
            // 
            this.UI_ToolStrip_LoadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UI_ToolStrip_LoadFile.Image = ((System.Drawing.Image)(resources.GetObject("UI_ToolStrip_LoadFile.Image")));
            this.UI_ToolStrip_LoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UI_ToolStrip_LoadFile.Name = "UI_ToolStrip_LoadFile";
            this.UI_ToolStrip_LoadFile.Size = new System.Drawing.Size(58, 22);
            this.UI_ToolStrip_LoadFile.Text = "Load File";
            // 
            // UI_ToolStrip_Analyze
            // 
            this.UI_ToolStrip_Analyze.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UI_ToolStrip_Analyze.Image = ((System.Drawing.Image)(resources.GetObject("UI_ToolStrip_Analyze.Image")));
            this.UI_ToolStrip_Analyze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UI_ToolStrip_Analyze.Name = "UI_ToolStrip_Analyze";
            this.UI_ToolStrip_Analyze.Size = new System.Drawing.Size(52, 22);
            this.UI_ToolStrip_Analyze.Text = "Analyze";
            // 
            // UI_ToolStrip_Algorithm
            // 
            this.UI_ToolStrip_Algorithm.Items.AddRange(new object[] {
            "Raw Access",
            "Library Helpers",
            "Binary Search"});
            this.UI_ToolStrip_Algorithm.Name = "UI_ToolStrip_Algorithm";
            this.UI_ToolStrip_Algorithm.Size = new System.Drawing.Size(121, 25);
            this.UI_ToolStrip_Algorithm.Text = "Raw Access";
            // 
            // UI_ToolStrip_SelectedView
            // 
            this.UI_ToolStrip_SelectedView.Items.AddRange(new object[] {
            "All Packages (Load)",
            "Loadable Packages (Load)",
            "Unloadable Packages (Load)"});
            this.UI_ToolStrip_SelectedView.Name = "UI_ToolStrip_SelectedView";
            this.UI_ToolStrip_SelectedView.Size = new System.Drawing.Size(121, 25);
            this.UI_ToolStrip_SelectedView.Text = "All Packages (Load)";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(898, 380);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // UI_StatusStrip_Main
            // 
            this.UI_StatusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UI_StatusStrip_PackagesLoaded,
            this.UI_StatusStrip_PackagesInstallable,
            this.UI_StatusStrip_PackagesUninstallable});
            this.UI_StatusStrip_Main.Location = new System.Drawing.Point(0, 411);
            this.UI_StatusStrip_Main.Name = "UI_StatusStrip_Main";
            this.UI_StatusStrip_Main.Size = new System.Drawing.Size(898, 22);
            this.UI_StatusStrip_Main.TabIndex = 2;
            this.UI_StatusStrip_Main.Text = "statusStrip1";
            // 
            // UI_StatusStrip_PackagesLoaded
            // 
            this.UI_StatusStrip_PackagesLoaded.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UI_StatusStrip_PackagesLoaded.Name = "UI_StatusStrip_PackagesLoaded";
            this.UI_StatusStrip_PackagesLoaded.Size = new System.Drawing.Size(98, 17);
            this.UI_StatusStrip_PackagesLoaded.Text = "Packages Loaded";
            // 
            // UI_StatusStrip_PackagesInstallable
            // 
            this.UI_StatusStrip_PackagesInstallable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UI_StatusStrip_PackagesInstallable.Name = "UI_StatusStrip_PackagesInstallable";
            this.UI_StatusStrip_PackagesInstallable.Size = new System.Drawing.Size(112, 17);
            this.UI_StatusStrip_PackagesInstallable.Text = "Packages Installable";
            // 
            // UI_StatusStrip_PackagesUninstallable
            // 
            this.UI_StatusStrip_PackagesUninstallable.BackColor = System.Drawing.Color.Red;
            this.UI_StatusStrip_PackagesUninstallable.Name = "UI_StatusStrip_PackagesUninstallable";
            this.UI_StatusStrip_PackagesUninstallable.Size = new System.Drawing.Size(127, 17);
            this.UI_StatusStrip_PackagesUninstallable.Text = "Packages Uninstallable";
            // 
            // UI_MainForm_Installotron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 433);
            this.Controls.Add(this.UI_StatusStrip_Main);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UI_MainForm_Installotron";
            this.Text = "Lab02Installotron";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.UI_StatusStrip_Main.ResumeLayout(false);
            this.UI_StatusStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UI_ToolStrip_LoadFile;
        private System.Windows.Forms.ToolStripButton UI_ToolStrip_Analyze;
        private System.Windows.Forms.ToolStripComboBox UI_ToolStrip_Algorithm;
        private System.Windows.Forms.ToolStripComboBox UI_ToolStrip_SelectedView;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.StatusStrip UI_StatusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel UI_StatusStrip_PackagesLoaded;
        private System.Windows.Forms.ToolStripStatusLabel UI_StatusStrip_PackagesInstallable;
        private System.Windows.Forms.ToolStripStatusLabel UI_StatusStrip_PackagesUninstallable;
    }
}

