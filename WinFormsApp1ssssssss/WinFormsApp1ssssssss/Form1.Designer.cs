namespace WinFormsApp1ssssssss
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxSpeaker;
        private System.Windows.Forms.Button buttonMute;

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
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxSpeaker = new System.Windows.Forms.PictureBox();
            this.buttonMute = new System.Windows.Forms.Button();   // ← Новая кнопка
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeaker)).BeginInit();
            this.SuspendLayout();

            // trackBarVolume
            this.trackBarVolume.Location = new System.Drawing.Point(80, 120);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(300, 45);
            this.trackBarVolume.TabIndex = 0;
            this.trackBarVolume.Value = 50;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);

            // buttonMute
            this.buttonMute.Location = new System.Drawing.Point(80, 220);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(140, 40);
            this.buttonMute.TabIndex = 4;
            this.buttonMute.Text = "Выключить звук";
            this.buttonMute.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonMute.Click += new System.EventHandler(this.buttonMute_Click);

            // labelTitle
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(80, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(220, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Симуляция громкости";

            // labelVolume
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelVolume.Location = new System.Drawing.Point(80, 180);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(140, 21);
            this.labelVolume.TabIndex = 2;
            this.labelVolume.Text = "Громкость: 50%";

            // pictureBoxSpeaker
            this.pictureBoxSpeaker.Location = new System.Drawing.Point(30, 110);
            this.pictureBoxSpeaker.Name = "pictureBoxSpeaker";
            this.pictureBoxSpeaker.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxSpeaker.TabIndex = 3;
            this.pictureBoxSpeaker.TabStop = false;
            this.pictureBoxSpeaker.Text = "звук ести";

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 290);
            this.Controls.Add(this.buttonMute);
            this.Controls.Add(this.pictureBoxSpeaker);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.trackBarVolume);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpeaker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}