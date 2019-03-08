namespace ToolMenuStrip
{
    partial class frmStartProject
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
            this.btnMenuStrip = new System.Windows.Forms.Button();
            this.btnContextTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuStrip
            // 
            this.btnMenuStrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuStrip.ForeColor = System.Drawing.Color.Black;
            this.btnMenuStrip.Location = new System.Drawing.Point(12, 12);
            this.btnMenuStrip.Name = "btnMenuStrip";
            this.btnMenuStrip.Size = new System.Drawing.Size(136, 23);
            this.btnMenuStrip.TabIndex = 0;
            this.btnMenuStrip.Text = "Context Menu Strip";
            this.btnMenuStrip.UseVisualStyleBackColor = true;
            this.btnMenuStrip.Click += new System.EventHandler(this.btnMenuStrip_Click);
            // 
            // btnContextTwo
            // 
            this.btnContextTwo.Location = new System.Drawing.Point(12, 41);
            this.btnContextTwo.Name = "btnContextTwo";
            this.btnContextTwo.Size = new System.Drawing.Size(136, 24);
            this.btnContextTwo.TabIndex = 1;
            this.btnContextTwo.Text = "Context Menu Strip";
            this.btnContextTwo.UseVisualStyleBackColor = true;
            this.btnContextTwo.Click += new System.EventHandler(this.btnContextTwo_Click);
            // 
            // frmStartProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 190);
            this.Controls.Add(this.btnContextTwo);
            this.Controls.Add(this.btnMenuStrip);
            this.Name = "frmStartProject";
            this.Text = "Start Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuStrip;
        private System.Windows.Forms.Button btnContextTwo;
    }
}

