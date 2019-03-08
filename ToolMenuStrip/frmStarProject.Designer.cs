namespace ToolMenuStrip
{
    partial class StartProject
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
            this.button2 = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // StartProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 190);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMenuStrip);
            this.Name = "StartProject";
            this.Text = "Start Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuStrip;
        private System.Windows.Forms.Button button2;
    }
}

