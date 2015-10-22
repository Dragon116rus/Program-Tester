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
        public string programPath;
        public Program1(string path)
        {
            InitializeComponent();

            programPath = path;
            using (StreamReader sw = new StreamReader(programPath)) {
       
                
                programText.Document.LineSpacing=0.5 ;
                programText.ChangeFontSize(10);
                programText.ChangeFontFamily(new Telerik.WinControls.RichTextEditor.UI.FontFamily("Arial"));
                programText.BorderColor = Color.DarkOrange;
                programText.ChangeTextForeColor(Color.DarkOrange);
                programText.Insert(sw.ReadToEnd());
              
            }
            
        }

        private void save_Click(object sender, EventArgs e) {
            
            using (StreamWriter sw = new StreamWriter(programPath)) {
                sw.Write(programText.Text);
            }
        }

        private void pathOfProgram_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            programPath = ofd.FileName;
            using(StreamReader sr=new StreamReader(programPath)) {
                
                programText.Insert(sr.ReadToEnd());
            }
        }
    }
}
