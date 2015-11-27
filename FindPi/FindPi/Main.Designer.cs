namespace FindPi
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
            this.enterBttn = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.mainLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterBttn
            // 
            this.enterBttn.Location = new System.Drawing.Point(50, 63);
            this.enterBttn.Name = "enterBttn";
            this.enterBttn.Size = new System.Drawing.Size(100, 23);
            this.enterBttn.TabIndex = 0;
            this.enterBttn.Text = "Enter";
            this.enterBttn.UseVisualStyleBackColor = true;
            this.enterBttn.Click += new System.EventHandler(this.enterBttn_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(50, 37);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 1;
            // 
            // mainLbl
            // 
            this.mainLbl.AutoSize = true;
            this.mainLbl.Location = new System.Drawing.Point(21, 9);
            this.mainLbl.Name = "mainLbl";
            this.mainLbl.Size = new System.Drawing.Size(35, 13);
            this.mainLbl.TabIndex = 2;
            this.mainLbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 98);
            this.Controls.Add(this.mainLbl);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.enterBttn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enterBttn;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label mainLbl;
    }
}

