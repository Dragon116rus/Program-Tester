namespace Tester
{
    partial class Program1
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
            this.programText = new Telerik.WinControls.UI.RadRichTextEditor();
            this.pathOfProgram = new Telerik.WinControls.UI.RadButton();
            this.save = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            ((System.ComponentModel.ISupportInitialize)(this.programText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathOfProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // programText
            // 
            this.programText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.programText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.programText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(189)))), ((int)(((byte)(232)))));
            this.programText.CaretWidth = float.NaN;
            this.programText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.programText.ForeColor = System.Drawing.Color.DarkOrange;
            this.programText.HorizontalScrollBarVisibility = Telerik.WinControls.RichTextEditor.UI.ScrollBarVisibility.Hidden;
            this.programText.Location = new System.Drawing.Point(12, 12);
            this.programText.Name = "programText";
            this.programText.SelectionFill = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.programText.Size = new System.Drawing.Size(403, 292);
            this.programText.TabIndex = 0;
            this.programText.ThemeName = "VisualStudio2012Dark";
            // 
            // pathOfProgram
            // 
            this.pathOfProgram.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pathOfProgram.Location = new System.Drawing.Point(12, 310);
            this.pathOfProgram.Name = "pathOfProgram";
            this.pathOfProgram.Size = new System.Drawing.Size(110, 24);
            this.pathOfProgram.TabIndex = 1;
            this.pathOfProgram.Text = "pathOfProgram";
            this.pathOfProgram.ThemeName = "VisualStudio2012Dark";
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(305, 310);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(110, 24);
            this.save.TabIndex = 2;
            this.save.Text = "save";
            this.save.ThemeName = "VisualStudio2012Dark";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 346);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pathOfProgram);
            this.Controls.Add(this.programText);
            this.Name = "Program1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Текст программы";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.programText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathOfProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadRichTextEditor programText;
        private Telerik.WinControls.UI.RadButton pathOfProgram;
        private Telerik.WinControls.UI.RadButton save;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
    }
}
