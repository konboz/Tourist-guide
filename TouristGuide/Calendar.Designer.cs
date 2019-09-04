namespace TouristGuide
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.μενούtoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ιστορικόtoolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.καθαρισμόςΙστορικούtoolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.έξοδοςtoolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.μενούtoolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // μενούtoolStripMenuItem1
            // 
            this.μενούtoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ιστορικόtoolStripMenuItem2,
            this.καθαρισμόςΙστορικούtoolStripMenuItem3,
            this.έξοδοςtoolStripMenuItem4});
            this.μενούtoolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.μενούtoolStripMenuItem1.ForeColor = System.Drawing.Color.OrangeRed;
            this.μενούtoolStripMenuItem1.Name = "μενούtoolStripMenuItem1";
            this.μενούtoolStripMenuItem1.Size = new System.Drawing.Size(60, 21);
            this.μενούtoolStripMenuItem1.Text = "Μενού";
            // 
            // ιστορικόtoolStripMenuItem2
            // 
            this.ιστορικόtoolStripMenuItem2.Name = "ιστορικόtoolStripMenuItem2";
            this.ιστορικόtoolStripMenuItem2.Size = new System.Drawing.Size(208, 22);
            this.ιστορικόtoolStripMenuItem2.Text = "Ιστορικό";
            // 
            // καθαρισμόςΙστορικούtoolStripMenuItem3
            // 
            this.καθαρισμόςΙστορικούtoolStripMenuItem3.Name = "καθαρισμόςΙστορικούtoolStripMenuItem3";
            this.καθαρισμόςΙστορικούtoolStripMenuItem3.Size = new System.Drawing.Size(208, 22);
            this.καθαρισμόςΙστορικούtoolStripMenuItem3.Text = "Καθαρισμός Ιστορικού";
            // 
            // έξοδοςtoolStripMenuItem4
            // 
            this.έξοδοςtoolStripMenuItem4.Name = "έξοδοςtoolStripMenuItem4";
            this.έξοδοςtoolStripMenuItem4.Size = new System.Drawing.Size(208, 22);
            this.έξοδοςtoolStripMenuItem4.Text = "Έξοδος";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(586, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(261, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 194);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ημερολόγιο";
            this.groupBox1.Visible = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 21);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem μενούtoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ιστορικόtoolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem καθαρισμόςΙστορικούtoolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem έξοδοςtoolStripMenuItem4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}