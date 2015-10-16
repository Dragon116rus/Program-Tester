namespace Tester
{
    partial class Main
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
            this.testing = new System.Windows.Forms.Button();
            this.tests = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.testResultList = new Telerik.WinControls.UI.RadListView();
            ((System.ComponentModel.ISupportInitialize)(this.testResultList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // testing
            // 
            this.testing.Location = new System.Drawing.Point(13, 13);
            this.testing.Name = "testing";
            this.testing.Size = new System.Drawing.Size(75, 23);
            this.testing.TabIndex = 0;
            this.testing.Text = "testing";
            this.testing.UseVisualStyleBackColor = true;
            this.testing.Click += new System.EventHandler(this.testing_Click);
            // 
            // tests
            // 
            this.tests.Location = new System.Drawing.Point(95, 13);
            this.tests.Name = "tests";
            this.tests.Size = new System.Drawing.Size(75, 23);
            this.tests.TabIndex = 1;
            this.tests.Text = "tests";
            this.tests.UseVisualStyleBackColor = true;
            this.tests.Click += new System.EventHandler(this.tests_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "program";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // testResultList
            // 
            this.testResultList.Location = new System.Drawing.Point(13, 43);
            this.testResultList.Name = "testResultList";
            this.testResultList.Size = new System.Drawing.Size(239, 209);
            this.testResultList.TabIndex = 3;
            this.testResultList.Text = "radListView1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 264);
            this.Controls.Add(this.testResultList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tests);
            this.Controls.Add(this.testing);
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.testResultList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testing;
        private System.Windows.Forms.Button tests;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.RadListView testResultList;
    }
}
