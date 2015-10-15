using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Tester
{
    public partial class Main : Telerik.WinControls.UI.RadForm
    {
        string compiler = "c++";
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Program1 form1 = new Program1();
            form1.Show(this);
        }

        private void tests_Click(object sender, EventArgs e) {
            Tests form1 = new Tests();
            form1.Show(this);
        }

        private void testing_Click(object sender, EventArgs e) {
            Process cmd = new Process();
            cmd.StartInfo = new ProcessStartInfo(@"cmd.exe");
            cmd.StartInfo.RedirectStandardInput = true;// перенаправить вход
            cmd.StartInfo.RedirectStandardOutput = true;//перенаправить выход
            cmd.StartInfo.UseShellExecute = false;//обязательный параметр, для работы предыдущих
           
            cmd.Start();
            
            cmd.StandardInput.WriteLine(compiler+@" program.cpp");
            int i = 1;
            while ((File.Exists(string.Format("tests/test{0}", i)))) {
                cmd.StandardInput.WriteLine(string.Format("a.exe < tests/test{0} > check"),i);
                using (StreamReader srCheck=new StreamReader("check")) {
                    using (StreamReader srAnswer= new StreamReader(string.Format("tests/answer{0}", i)))
                        ;
                }
                i++;
            }
        }
    }
}
