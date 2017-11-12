﻿namespace CMPE2300Lab2
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
            this.UI_toolStrip = new System.Windows.Forms.ToolStrip();
            this.UI_ToolStrip_LoadFile = new System.Windows.Forms.ToolStripButton();
            this.UI_ToolStrip_Analyze = new System.Windows.Forms.ToolStripButton();
            this.UI_ToolStrip_Algorithm = new System.Windows.Forms.ToolStripComboBox();
            this.UI_ToolStrip_SelectedView = new System.Windows.Forms.ToolStripComboBox();
            this.UI_ListView_Text = new System.Windows.Forms.ListView();
            this.UI_ListViewColumn_Package = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UI_ListViewColumn_Dependencies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UI_StatusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.UI_StatusStrip_PackagesLoaded = new System.Windows.Forms.ToolStripStatusLabel();
            this.UI_StatusStrip_PackagesInstallable = new System.Windows.Forms.ToolStripStatusLabel();
            this.UI_StatusStrip_PackagesUninstallable = new System.Windows.Forms.ToolStripStatusLabel();
            this.UI_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.UI_ToolStripItem_Timer = new System.Windows.Forms.ToolStripStatusLabel();
            this.UI_toolStrip.SuspendLayout();
            this.UI_StatusStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_toolStrip
            // 
            this.UI_toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UI_ToolStrip_LoadFile,
            this.UI_ToolStrip_SelectedView,
            this.UI_ToolStrip_Analyze,
            this.UI_ToolStrip_Algorithm});
            this.UI_toolStrip.Location = new System.Drawing.Point(0, 0);
            this.UI_toolStrip.Name = "UI_toolStrip";
            this.UI_toolStrip.Size = new System.Drawing.Size(898, 25);
            this.UI_toolStrip.TabIndex = 0;
            this.UI_toolStrip.Text = "toolStrip1";
            // 
            // UI_ToolStrip_LoadFile
            // 
            this.UI_ToolStrip_LoadFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UI_ToolStrip_LoadFile.Image = ((System.Drawing.Image)(resources.GetObject("UI_ToolStrip_LoadFile.Image")));
            this.UI_ToolStrip_LoadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UI_ToolStrip_LoadFile.Name = "UI_ToolStrip_LoadFile";
            this.UI_ToolStrip_LoadFile.Size = new System.Drawing.Size(58, 22);
            this.UI_ToolStrip_LoadFile.Text = "Load File";
            this.UI_ToolStrip_LoadFile.Click += new System.EventHandler(this.UI_ToolStrip_LoadFile_Click);
            // 
            // UI_ToolStrip_Analyze
            // 
            this.UI_ToolStrip_Analyze.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UI_ToolStrip_Analyze.Image = ((System.Drawing.Image)(resources.GetObject("UI_ToolStrip_Analyze.Image")));
            this.UI_ToolStrip_Analyze.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UI_ToolStrip_Analyze.Name = "UI_ToolStrip_Analyze";
            this.UI_ToolStrip_Analyze.Size = new System.Drawing.Size(52, 22);
            this.UI_ToolStrip_Analyze.Text = "Analyze";
            this.UI_ToolStrip_Analyze.Click += new System.EventHandler(this.UI_ToolStrip_Analyze_Click);
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
            // UI_ListView_Text
            // 
            this.UI_ListView_Text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_ListView_Text.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UI_ListViewColumn_Package,
            this.UI_ListViewColumn_Dependencies});
            this.UI_ListView_Text.GridLines = true;
            this.UI_ListView_Text.Location = new System.Drawing.Point(0, 28);
            this.UI_ListView_Text.Name = "UI_ListView_Text";
            this.UI_ListView_Text.Size = new System.Drawing.Size(898, 380);
            this.UI_ListView_Text.TabIndex = 1;
            this.UI_ListView_Text.UseCompatibleStateImageBehavior = false;
            this.UI_ListView_Text.View = System.Windows.Forms.View.Details;
            // 
            // UI_ListViewColumn_Package
            // 
            this.UI_ListViewColumn_Package.Text = "Package";
            this.UI_ListViewColumn_Package.Width = 200;
            // 
            // UI_ListViewColumn_Dependencies
            // 
            this.UI_ListViewColumn_Dependencies.Text = "Dependencies";
            this.UI_ListViewColumn_Dependencies.Width = 700;
            // 
            // UI_StatusStrip_Main
            // 
            this.UI_StatusStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UI_StatusStrip_PackagesLoaded,
            this.UI_StatusStrip_PackagesInstallable,
            this.UI_StatusStrip_PackagesUninstallable,
            this.UI_ToolStripItem_Timer});
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
            // UI_openFileDialog
            // 
            this.UI_openFileDialog.FileName = "openFileDialog1";
            this.UI_openFileDialog.Filter = "txt files|*.txt|All files|*.*";
            // 
            // UI_ToolStripItem_Timer
            // 
            this.UI_ToolStripItem_Timer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UI_ToolStripItem_Timer.ForeColor = System.Drawing.Color.Blue;
            this.UI_ToolStripItem_Timer.Name = "UI_ToolStripItem_Timer";
            this.UI_ToolStripItem_Timer.Size = new System.Drawing.Size(85, 17);
            this.UI_ToolStripItem_Timer.Text = "Completed in: ";
            // 
            // UI_MainForm_Installotron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 433);
            this.Controls.Add(this.UI_StatusStrip_Main);
            this.Controls.Add(this.UI_ListView_Text);
            this.Controls.Add(this.UI_toolStrip);
            this.Name = "UI_MainForm_Installotron";
            this.Text = "Lab02Installotron";
            this.UI_toolStrip.ResumeLayout(false);
            this.UI_toolStrip.PerformLayout();
            this.UI_StatusStrip_Main.ResumeLayout(false);
            this.UI_StatusStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip UI_toolStrip;
        private System.Windows.Forms.ToolStripButton UI_ToolStrip_LoadFile;
        private System.Windows.Forms.ToolStripButton UI_ToolStrip_Analyze;
        private System.Windows.Forms.ToolStripComboBox UI_ToolStrip_Algorithm;
        private System.Windows.Forms.ToolStripComboBox UI_ToolStrip_SelectedView;
        private System.Windows.Forms.ListView UI_ListView_Text;
        private System.Windows.Forms.StatusStrip UI_StatusStrip_Main;
        private System.Windows.Forms.ToolStripStatusLabel UI_StatusStrip_PackagesLoaded;
        private System.Windows.Forms.ToolStripStatusLabel UI_StatusStrip_PackagesInstallable;
        private System.Windows.Forms.ToolStripStatusLabel UI_StatusStrip_PackagesUninstallable;
        private System.Windows.Forms.OpenFileDialog UI_openFileDialog;
        private System.Windows.Forms.ColumnHeader UI_ListViewColumn_Package;
        private System.Windows.Forms.ColumnHeader UI_ListViewColumn_Dependencies;
        private System.Windows.Forms.ToolStripStatusLabel UI_ToolStripItem_Timer;
    }
}

