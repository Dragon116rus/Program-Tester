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
                TestsList.Items.Add(name);
            }
        }

        private void Create_Click(object sender, EventArgs e) {
            int i = 1;
            while ((File.Exists(string.Format("tests/test{0}", i)))) {
                i++;
            }
            using (StreamWriter sw=new StreamWriter(string.Format("tests/test{0}", i))) {
                sw.Write(test.Text);
            }
            TestsList.Items.Add(string.Format("test{0}", i));
            
        }

        private void Delete_Click(object sender, EventArgs e) {
            File.Delete(TestsList.SelectedItems[0].Text);
            TestsList.Items.Remove(TestsList.SelectedItems[0]);
        }
    }
}
