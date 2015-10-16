namespace Tester
{
    partial class Tests
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
            this.test = new Telerik.WinControls.UI.RadRichTextEditor();
            this.TestsList = new Telerik.WinControls.UI.RadListView();
            this.Create = new Telerik.WinControls.UI.RadButton();
            this.Delete = new Telerik.WinControls.UI.RadButton();
            this.answer = new Telerik.WinControls.UI.RadRichTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Create)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.test.CaretWidth = float.NaN;
            this.test.Location = new System.Drawing.Point(12, 12);
            this.test.Name = "test";
            this.test.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.test.Size = new System.Drawing.Size(184, 138);
            this.test.TabIndex = 0;
            // 
            // TestsList
            // 
            this.TestsList.Location = new System.Drawing.Point(203, 13);
            this.TestsList.Name = "TestsList";
            this.TestsList.Size = new System.Drawing.Size(120, 199);
            this.TestsList.TabIndex = 1;
            this.TestsList.Text = "radListView1";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(13, 219);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(110, 24);
            this.Create.TabIndex = 2;
            this.Create.Text = "Create";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(203, 218);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(110, 24);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // answer
            // 
            this.answer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.answer.CaretWidth = float.NaN;
            this.answer.Location = new System.Drawing.Point(12, 156);
            this.answer.Name = "answer";
            this.answer.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.answer.Size = new System.Drawing.Size(184, 57);
            this.answer.TabIndex = 4;
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 270);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.TestsList);
            this.Controls.Add(this.test);
            this.Name = "Tests";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Tests";
            ((System.ComponentModel.ISupportInitialize)(this.test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Create)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadRichTextEditor test;
        private Telerik.WinControls.UI.RadListView TestsList;
        private Telerik.WinControls.UI.RadButton Create;
        private Telerik.WinControls.UI.RadButton Delete;
        private Telerik.WinControls.UI.RadRichTextEditor answer;
    }
}
