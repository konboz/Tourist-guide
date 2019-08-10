namespace TouristGuide
{
    partial class SightForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.μενούToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.πίσωToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.αποθήκευσηΠληροφοριώνToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ιστορικόToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.έξοδοςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.καθαρισμόςToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(573, 335);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(35, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(791, 265);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.μενούToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // μενούToolStripMenuItem
            // 
            this.μενούToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.πίσωToolStripMenuItem,
            this.ιστορικόToolStripMenuItem,
            this.αποθήκευσηΠληροφοριώνToolStripMenuItem,
            this.έξοδοςToolStripMenuItem});
            this.μενούToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.μενούToolStripMenuItem.Name = "μενούToolStripMenuItem";
            this.μενούToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.μενούToolStripMenuItem.Text = "Μενού";
            this.μενούToolStripMenuItem.Click += new System.EventHandler(this.μενούToolStripMenuItem_Click);
            // 
            // πίσωToolStripMenuItem
            // 
            this.πίσωToolStripMenuItem.Name = "πίσωToolStripMenuItem";
            this.πίσωToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.πίσωToolStripMenuItem.Text = "Πίσω";
            this.πίσωToolStripMenuItem.Click += new System.EventHandler(this.ΠίσωToolStripMenuItem_Click);
            // 
            // αποθήκευσηΠληροφοριώνToolStripMenuItem
            // 
            this.αποθήκευσηΠληροφοριώνToolStripMenuItem.Name = "αποθήκευσηΠληροφοριώνToolStripMenuItem";
            this.αποθήκευσηΠληροφοριώνToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.αποθήκευσηΠληροφοριώνToolStripMenuItem.Text = "Αποθήκευση πληροφοριών";
            this.αποθήκευσηΠληροφοριώνToolStripMenuItem.Click += new System.EventHandler(this.ΑποθήκευσηΠληροφοριώνToolStripMenuItem_Click);
            // 
            // ιστορικόToolStripMenuItem
            // 
            this.ιστορικόToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.καθαρισμόςToolStripMenuItem});
            this.ιστορικόToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ιστορικόToolStripMenuItem.Name = "ιστορικόToolStripMenuItem";
            this.ιστορικόToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.ιστορικόToolStripMenuItem.Text = "Ιστορικό";
            // 
            // έξοδοςToolStripMenuItem
            // 
            this.έξοδοςToolStripMenuItem.Name = "έξοδοςToolStripMenuItem";
            this.έξοδοςToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.έξοδοςToolStripMenuItem.Text = "Έξοδος";
            this.έξοδοςToolStripMenuItem.Click += new System.EventHandler(this.ΈξοδοςToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files | *.txt";
            // 
            // καθαρισμόςToolStripMenuItem
            // 
            this.καθαρισμόςToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.καθαρισμόςToolStripMenuItem.Name = "καθαρισμόςToolStripMenuItem";
            this.καθαρισμόςToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.καθαρισμόςToolStripMenuItem.Text = "Καθαρισμός";
            this.καθαρισμόςToolStripMenuItem.Click += new System.EventHandler(this.καθαρισμόςToolStripMenuItem_Click_1);
            // 
            // SightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 614);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SightForm";
            this.Load += new System.EventHandler(this.SightForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem μενούToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem πίσωToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem έξοδοςToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem αποθήκευσηΠληροφοριώνToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem ιστορικόToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem καθαρισμόςToolStripMenuItem;
    }
}