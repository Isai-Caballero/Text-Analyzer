namespace Text_Analyzer_GUI
{
    partial class Form1
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
            this.txtBoxTest = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.lblNumOfSent = new System.Windows.Forms.Label();
            this.lstBxUnique = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxTest
            // 
            this.txtBoxTest.Location = new System.Drawing.Point(14, 14);
            this.txtBoxTest.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxTest.Multiline = true;
            this.txtBoxTest.Name = "txtBoxTest";
            this.txtBoxTest.Size = new System.Drawing.Size(570, 451);
            this.txtBoxTest.TabIndex = 0;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(14, 475);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(5);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(303, 98);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // lblNumOfSent
            // 
            this.lblNumOfSent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumOfSent.Location = new System.Drawing.Point(592, 14);
            this.lblNumOfSent.Name = "lblNumOfSent";
            this.lblNumOfSent.Size = new System.Drawing.Size(329, 188);
            this.lblNumOfSent.TabIndex = 5;
            // 
            // lstBxUnique
            // 
            this.lstBxUnique.FormattingEnabled = true;
            this.lstBxUnique.ItemHeight = 24;
            this.lstBxUnique.Location = new System.Drawing.Point(592, 221);
            this.lstBxUnique.Name = "lstBxUnique";
            this.lstBxUnique.Size = new System.Drawing.Size(329, 244);
            this.lstBxUnique.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(325, 475);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(259, 98);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(592, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(329, 98);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAnalyze;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(935, 590);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstBxUnique);
            this.Controls.Add(this.lblNumOfSent);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.txtBoxTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTest;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label lblNumOfSent;
        private System.Windows.Forms.ListBox lstBxUnique;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

