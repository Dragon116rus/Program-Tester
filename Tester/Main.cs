using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Tester {
    public partial class Main : Telerik.WinControls.UI.RadForm {
        internal string compiler = "g++";
        public Main() {
            InitializeComponent();
            testResultList.MultiSelect = false;
            
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
            Thread thread = new Thread(Testing);
            thread.Start();
        }
        void Testing() {
            Process cmd = new Process();
            cmd.StartInfo = new ProcessStartInfo(@"cmd.exe");
            cmd.StartInfo.RedirectStandardInput = true;// перенаправить вход
            cmd.StartInfo.RedirectStandardOutput = true;//перенаправить выход
            cmd.StartInfo.UseShellExecute = false;//обязательный параметр, для работы предыдущих
            cmd.StartInfo.CreateNoWindow = true;
            cmd.Start();

            cmd.StandardInput.WriteLine(compiler + @" program.cpp");
            cmd.StandardInput.WriteLine("exit");
            cmd.Close();
            int i = 1;


            Process program = new Process();
            while ((File.Exists(string.Format("tests/test{0}", i))) && (File.Exists(string.Format("tests/test{0}a", i)))) {
                program.StartInfo = new ProcessStartInfo(@"a.exe");
                program.StartInfo.RedirectStandardInput = true;// перенаправить вход
                program.StartInfo.RedirectStandardOutput = true;//перенаправить выход
                program.StartInfo.UseShellExecute = false;//обязательный параметр, для работы предыдущих
                program.StartInfo.CreateNoWindow = true;
                program.Start();
                using (StreamReader srTest = new StreamReader(String.Format("tests/test{0}", i))) {
                    program.StandardInput.WriteLine(srTest.ReadToEnd());
                }

                StreamReader sr = program.StandardOutput;
                Invoke((MethodInvoker)delegate {
                    testResultList.Items.Add(Checker(string.Format("tests/test{0}a", i), sr));
                });

                program.Close();
                i++;
            }
            cmd.Close();
        }
        ListViewDataItem Checker(string path, StreamReader sr) {
            var item = new ListViewDataItem();
            StreamReader srAnswer = new StreamReader(path);
           
            string[] answer = srAnswer.ReadToEnd().Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] trueAnswer = sr.ReadToEnd().Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (trueAnswer.Length < answer.Length) {
                item.BackColor = Color.Red;
                item.Text = "Error:a different number of characters";
                return item;
            }
            for (int i = 0; i < trueAnswer.Length; i++) {
                if (trueAnswer[i] != answer[i]) {
                    item.BackColor = Color.FromArgb(255, 58, 31);
                    item.GradientStyle = GradientStyles.Solid;
                    item.Text = "Error:different value";
                    return item;
                }
            }
            sr.Close();
            srAnswer.Close();
            item.BackColor = Color.GreenYellow;
            item.GradientStyle = GradientStyles.Solid;
            item.Text = "true";
            return item;

        }

    }
}
