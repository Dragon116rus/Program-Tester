using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Tester {
    public partial class Tests : Telerik.WinControls.UI.RadForm {
        public Tests() {
            InitializeComponent();           
            foreach(var name in Directory.GetFiles("tests")) {
                if (File.Exists(name+"a"))
                    TestsList.Items.Add(name);
            }
            test.ChangeTextForeColor( Color.DarkOrange);
            answer.ChangeTextForeColor(Color.DarkOrange);
        }

        private void Create_Click(object sender, EventArgs e) {
            int i = 1;
            while ((File.Exists(string.Format("tests/test{0}", i)))) {
                i++;
            }
            using (StreamWriter sw=new StreamWriter(string.Format("tests/test{0}", i))) {
                sw.Write(test.Text);
            }
            using (StreamWriter sw=new StreamWriter(string.Format("tests/test{0}a",i))) {
                sw.Write(answer.Text);
            }
            TestsList.Items.Add(string.Format("test{0}", i));
            
        }

        private void Delete_Click(object sender, EventArgs e) {
            File.Delete(TestsList.SelectedItems[0].Text);
            TestsList.Items.Remove(TestsList.SelectedItems[0]);
        }

        private void TestsList_ItemMouseClick(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e) {
            using (StreamReader sw = new StreamReader(TestsList.SelectedItem.Text)) {
                test.Text = "";
                test.ChangeTextForeColor(Color.DarkOrange);
                test.Insert(sw.ReadToEnd());
            }
            using (StreamReader sw = new StreamReader(TestsList.SelectedItem.Text + "a")) {
                answer.Text = "";
                answer.ChangeTextForeColor(Color.DarkOrange);
                answer.Insert( sw.ReadToEnd());
            }
        }

        private void ChangeTest_Click(object sender, EventArgs e) {

            using (StreamWriter sw = new StreamWriter(string.Format(TestsList.SelectedItem.Text))) {
                sw.Write(test.Text);
            }
            using (StreamWriter sw = new StreamWriter(string.Format("{0}a", TestsList.SelectedItem.Text))) {
                sw.Write(answer.Text);
            }
        }
    }
}
