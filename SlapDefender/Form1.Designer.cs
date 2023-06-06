namespace SlapDefender
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DisableDefenderBtn = new System.Windows.Forms.PictureBox();
            this.enableDefenderBtn = new System.Windows.Forms.PictureBox();
            this.kucult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisableDefenderBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enableDefenderBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(151, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developer - ShadesOfDeath";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exit
            // 
            this.exit.Image = global::SlapDefender.Properties.Resources.close;
            this.exit.Location = new System.Drawing.Point(443, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(24, 23);
            this.exit.TabIndex = 7;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 129);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DisableDefenderBtn
            // 
            this.DisableDefenderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DisableDefenderBtn.Image = ((System.Drawing.Image)(resources.GetObject("DisableDefenderBtn.Image")));
            this.DisableDefenderBtn.Location = new System.Drawing.Point(195, 117);
            this.DisableDefenderBtn.Name = "DisableDefenderBtn";
            this.DisableDefenderBtn.Size = new System.Drawing.Size(246, 50);
            this.DisableDefenderBtn.TabIndex = 5;
            this.DisableDefenderBtn.TabStop = false;
            this.DisableDefenderBtn.Click += new System.EventHandler(this.DisableDefenderBtn_Click);
            // 
            // enableDefenderBtn
            // 
            this.enableDefenderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enableDefenderBtn.Image = ((System.Drawing.Image)(resources.GetObject("enableDefenderBtn.Image")));
            this.enableDefenderBtn.Location = new System.Drawing.Point(195, 49);
            this.enableDefenderBtn.Name = "enableDefenderBtn";
            this.enableDefenderBtn.Size = new System.Drawing.Size(246, 50);
            this.enableDefenderBtn.TabIndex = 0;
            this.enableDefenderBtn.TabStop = false;
            this.enableDefenderBtn.Click += new System.EventHandler(this.EnableDefenderBtn_Click);
            // 
            // kucult
            // 
            this.kucult.Image = ((System.Drawing.Image)(resources.GetObject("kucult.Image")));
            this.kucult.Location = new System.Drawing.Point(413, 5);
            this.kucult.Name = "kucult";
            this.kucult.Size = new System.Drawing.Size(24, 19);
            this.kucult.TabIndex = 8;
            this.kucult.TabStop = false;
            this.kucult.Click += new System.EventHandler(this.kucult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(469, 218);
            this.Controls.Add(this.kucult);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DisableDefenderBtn);
            this.Controls.Add(this.enableDefenderBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SlapDefender 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisableDefenderBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enableDefenderBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kucult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox enableDefenderBtn;
        private System.Windows.Forms.PictureBox DisableDefenderBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox kucult;
    }
}
