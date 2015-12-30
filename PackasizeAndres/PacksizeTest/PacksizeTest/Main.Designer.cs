namespace PacksizeTest
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
            this.LBLcourse = new System.Windows.Forms.Label();
            this.LBLprerequisite = new System.Windows.Forms.Label();
            this.TXTcouse = new System.Windows.Forms.TextBox();
            this.TXTprerequisite = new System.Windows.Forms.TextBox();
            this.BTNadd = new System.Windows.Forms.Button();
            this.BTNshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLcourse
            // 
            this.LBLcourse.AutoSize = true;
            this.LBLcourse.Location = new System.Drawing.Point(13, 13);
            this.LBLcourse.Name = "LBLcourse";
            this.LBLcourse.Size = new System.Drawing.Size(68, 13);
            this.LBLcourse.TabIndex = 0;
            this.LBLcourse.Text = "Couse Name";
            // 
            // LBLprerequisite
            // 
            this.LBLprerequisite.AutoSize = true;
            this.LBLprerequisite.Location = new System.Drawing.Point(13, 55);
            this.LBLprerequisite.Name = "LBLprerequisite";
            this.LBLprerequisite.Size = new System.Drawing.Size(62, 13);
            this.LBLprerequisite.TabIndex = 1;
            this.LBLprerequisite.Text = "Prerequisite";
            // 
            // TXTcouse
            // 
            this.TXTcouse.Location = new System.Drawing.Point(87, 12);
            this.TXTcouse.Name = "TXTcouse";
            this.TXTcouse.Size = new System.Drawing.Size(100, 20);
            this.TXTcouse.TabIndex = 0;
            // 
            // TXTprerequisite
            // 
            this.TXTprerequisite.Location = new System.Drawing.Point(87, 51);
            this.TXTprerequisite.Name = "TXTprerequisite";
            this.TXTprerequisite.Size = new System.Drawing.Size(100, 20);
            this.TXTprerequisite.TabIndex = 1;
            // 
            // BTNadd
            // 
            this.BTNadd.Location = new System.Drawing.Point(87, 88);
            this.BTNadd.Name = "BTNadd";
            this.BTNadd.Size = new System.Drawing.Size(100, 23);
            this.BTNadd.TabIndex = 2;
            this.BTNadd.Text = "Add couse";
            this.BTNadd.UseVisualStyleBackColor = true;
            this.BTNadd.Click += new System.EventHandler(this.BTNadd_Click);
            // 
            // BTNshow
            // 
            this.BTNshow.Location = new System.Drawing.Point(87, 126);
            this.BTNshow.Name = "BTNshow";
            this.BTNshow.Size = new System.Drawing.Size(100, 23);
            this.BTNshow.TabIndex = 3;
            this.BTNshow.Text = "Show Courses";
            this.BTNshow.UseVisualStyleBackColor = true;
            this.BTNshow.Click += new System.EventHandler(this.BTNshow_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 200);
            this.Controls.Add(this.BTNshow);
            this.Controls.Add(this.BTNadd);
            this.Controls.Add(this.TXTprerequisite);
            this.Controls.Add(this.TXTcouse);
            this.Controls.Add(this.LBLprerequisite);
            this.Controls.Add(this.LBLcourse);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLcourse;
        private System.Windows.Forms.Label LBLprerequisite;
        private System.Windows.Forms.TextBox TXTcouse;
        private System.Windows.Forms.TextBox TXTprerequisite;
        private System.Windows.Forms.Button BTNadd;
        private System.Windows.Forms.Button BTNshow;
    }
}

