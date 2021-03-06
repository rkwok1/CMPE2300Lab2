﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace CMPE2300Lab2
{
    public partial class UI_MainForm_Installotron : Form
    {
        List<Package> packageList = new List<Package>();
        List<Package> uninstalledList = new List<Package>();
        List<Package> installedList = new List<Package>();

        public UI_MainForm_Installotron()
        {
            InitializeComponent();
            //Autosizes the last column in the list view to take up the full space
            UI_ListView_Text.Columns[UI_ListView_Text.Columns.Count - 1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        /*******************************************Form Events*************************************************************/
        //When load File button is clicked...
        private void UI_ToolStrip_LoadFile_Click(object sender, EventArgs e)
        {

            //If user opens file dialog and checks ok
            if (UI_openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                StreamReader srInput = new StreamReader(UI_openFileDialog.FileName);
                string line = "";
                try
                {
                    //While end of file has not been reached
                    while ((line = srInput.ReadLine()) != null)
                    {
                        //Create a package that reads the line and splits of space characters
                        Package pack = new Package(line.Split(' '));
                        //If the global package list already has this package with the same name, merges it based on the index at which it is found in the list
                        if (packageList.Contains(pack))
                        {
                            packageList[packageList.FindIndex(a => a.Equals(pack))].MergePackage(pack);
                        }
                        //Otherwise, it is a new package, add it to the list
                        else
                        {
                            packageList.Add(pack);
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error Loading File: " + er.Message, "Load File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Show File output into list view
                ShowSelectedLoad();
            }

        }
        private void UI_ToolStrip_Analyze_Click(object sender, EventArgs e)
        {
            Analyze();
        }
        /****************************************************************Helper Methods**********************************************************/
        public void ShowSelectedLoad()
        {
            int selectedLoad = UI_ToolStrip_SelectedView.SelectedIndex;
            int counter = 0;
            switch (selectedLoad)
            {
                case 0:
                    //Loads all the packages in the global list of packages
                    foreach (Package pack in packageList)
                    {
                        //Adds name to first column
                        ListViewItem lviRow = UI_ListView_Text.Items.Add(pack.Name);
                        //Add Package dependencies to the subcolumn
                        lviRow.SubItems.Add(pack.ToString());
                        counter++;
                        
                    }
                    UI_StatusStrip_PackagesLoaded.Text = "Packages Loaded: " + counter;
                    break;
                case 1:
                    //Requires Analyze to be completed
                    break;
                case 2:
                    //Requires Analyze to be completed
                    break;

            }

        }

        public void Analyze()
        {
            Stopwatch timer = new Stopwatch();
            //Adds all loaded files to the uninstall list
            if (packageList.Count > 0)
            {
                packageList.ForEach(q => uninstalledList.Add(q));
            }
            UI_StatusStrip_PackagesUninstallable.Text = "Packages Uninstallable: " + uninstalledList.Count;
            installedList.Clear();
            //Start timer to determine how long the analyzing takes
            timer.Start();
            


            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            UI_ToolStripItem_Timer.Text = "Completed in " + ts.Milliseconds +"ms";
            
        }

        /**********************************************************Analyze Algorthim Members**************************************************/
        public void RawList()
        {
            for (int i = 0; i < uninstalledList.Count; i++)
            {
                //If the package has NO dependencies (independent of others)
                if (uninstalledList[i].pList.Count.Equals(0))
                {
                    //Add it to the installed list
                    installedList.Add(uninstalledList[i]);
                    //remove it from the uninstalled list as you just installed
                    uninstalledList.Remove(uninstalledList[i]);
                }
                else if (installedList[i].pList.Contains(uninstalledList[i].pList[i]))
                {

                }
               
            }
        }
        public void LibraryList()
        {

        }
        public void SortedList()
        {

        }
    }
}
