using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE2300Lab2
{
    public partial class UI_MainForm_Installotron : Form
    {
        enum AlgorithmSelection {eRawList, eLibraryList,eSortList};

        public UI_MainForm_Installotron()
        {
            InitializeComponent();
        }

        //When load File button is clicked...
        private void UI_ToolStrip_LoadFile_Click(object sender, EventArgs e)
        {
            //If user opens file dialog and checks ok
            if(UI_openFileDialog.ShowDialog().Equals( DialogResult.OK))
            {
                //Open Package
            }
        }
    }
}
