using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Tester
{
    public partial class Program1 : Telerik.WinControls.UI.RadForm
    {
        public Program1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e) {
            
            using (StreamWriter sw = new StreamWriter("program.cpp")) {
                sw.Write(programText.Text);
            }
        }
    }
}
