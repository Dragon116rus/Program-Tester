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
            this.testResultList = new Telerik.WinControls.UI.RadListView();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.checkTests = new Telerik.WinControls.UI.RadButton();
            this.programTest = new Telerik.WinControls.UI.RadButton();
            this.viewTests = new Telerik.WinControls.UI.RadButton();
            this.Clear = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.testResultList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // testResultList
            // 
            this.testResultList.AllowEdit = false;
            this.testResultList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.testResultList.Location = new System.Drawing.Point(12, 12);
            this.testResultList.Name = "testResultList";
            this.testResultList.Size = new System.Drawing.Size(224, 228);
            this.testResultList.TabIndex = 3;
            this.testResultList.ThemeName = "VisualStudio2012Dark";
            // 
            // checkTests
            // 
            this.checkTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTests.Location = new System.Drawing.Point(242, 10);
            this.checkTests.Name = "checkTests";
            this.checkTests.Size = new System.Drawing.Size(110, 24);
            this.checkTests.TabIndex = 4;
            this.checkTests.Text = "Проверка тестов";
            this.checkTests.ThemeName = "VisualStudio2012Dark";
            this.checkTests.Click += new System.EventHandler(this.checkTests_Click);
            // 
            // programTest
            // 
            this.programTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programTest.Location = new System.Drawing.Point(242, 65);
            this.programTest.MaximumSize = new System.Drawing.Size(108, 24);
            this.programTest.Name = "programTest";
            // 
            // 
            // 
            this.programTest.RootElement.MaxSize = new System.Drawing.Size(108, 24);
            this.programTest.Size = new System.Drawing.Size(108, 24);
            this.programTest.TabIndex = 5;
            this.programTest.Text = "Текст программы";
            this.programTest.ThemeName = "VisualStudio2012Dark";
            this.programTest.Click += new System.EventHandler(this.programTest_Click);
            // 
            // viewTests
            // 
            this.viewTests.Location = new System.Drawing.Point(242, 95);
            this.viewTests.Name = "viewTests";
            this.viewTests.Size = new System.Drawing.Size(110, 24);
            this.viewTests.TabIndex = 6;
            this.viewTests.Text = "Посмотреть тесты";
            this.viewTests.ThemeName = "VisualStudio2012Dark";
            this.viewTests.Click += new System.EventHandler(this.viewTests_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(242, 225);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(110, 24);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Очистить";
            this.Clear.ThemeName = "VisualStudio2012Dark";
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 264);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.viewTests);
            this.Controls.Add(this.programTest);
            this.Controls.Add(this.checkTests);
            this.Controls.Add(this.testResultList);
            this.MaximumSize = new System.Drawing.Size(372, 297);
            this.MinimumSize = new System.Drawing.Size(372, 297);
            this.Name = "Main";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(372, 297);
            this.Text = "Tester";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.testResultList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadListView testResultList;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadButton checkTests;
        private Telerik.WinControls.UI.RadButton programTest;
        private Telerik.WinControls.UI.RadButton viewTests;
        private Telerik.WinControls.UI.RadButton Clear;
    }
}
