namespace Employment_center_v2._0
{
    partial class aboutvacanciton
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
            this.profilelab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // profilelab
            // 
            this.profilelab.AutoSize = true;
            this.profilelab.Location = new System.Drawing.Point(40, 71);
            this.profilelab.Name = "profilelab";
            this.profilelab.Size = new System.Drawing.Size(35, 13);
            this.profilelab.TabIndex = 0;
            this.profilelab.Text = "label1";
            // 
            // aboutvacanciton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 556);
            this.Controls.Add(this.profilelab);
            this.Name = "aboutvacanciton";
            this.Text = "aboutvacanciton";
            this.Load += new System.EventHandler(this.aboutvacanciton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label profilelab;
    }
}