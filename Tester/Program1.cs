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

         
            using (StreamReader sw = new StreamReader("program.cpp")) {
       
                
                programText.Document.LineSpacing=0.5 ;
                programText.ChangeFontSize(10);
                programText.ChangeFontFamily(new Telerik.WinControls.RichTextEditor.UI.FontFamily("Arial"));
                programText.BorderColor = Color.DarkOrange;
                programText.ChangeTextForeColor(Color.DarkOrange);
                programText.Insert(sw.ReadToEnd());
              
            }
            
        }

        private void save_Click(object sender, EventArgs e) {
            
            using (StreamWriter sw = new StreamWriter("program.cpp")) {
                sw.Write(programText.Text);
            }
        }
    }
}
