namespace PhotoAlbum
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox comboBoxPhotos;
        private PictureBox pictureBoxPhoto;
        private Label labelTitle;
        private Label labelDescription;
        private GroupBox groupBoxPhoto;

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
            this.labelTitle = new Label();
            this.comboBoxPhotos = new ComboBox();
            this.groupBoxPhoto = new GroupBox();
            this.pictureBoxPhoto = new PictureBox();
            this.labelDescription = new Label();

            this.SuspendLayout();

            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.labelTitle.Location = new Point(30, 20);
            this.labelTitle.Text = "Фотоальбом";

            this.comboBoxPhotos.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxPhotos.Font = new Font("Segoe UI", 11F);
            this.comboBoxPhotos.Location = new Point(30, 70);
            this.comboBoxPhotos.Size = new Size(420, 30);
            this.comboBoxPhotos.SelectedIndexChanged += new EventHandler(this.comboBoxPhotos_SelectedIndexChanged);

            this.groupBoxPhoto.Location = new Point(30, 120);
            this.groupBoxPhoto.Size = new Size(500, 380);
            this.groupBoxPhoto.Text = "Просмотр фотографии";

            this.pictureBoxPhoto.Location = new Point(20, 25);
            this.pictureBoxPhoto.Size = new Size(460, 280);
            this.pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.BorderStyle = BorderStyle.FixedSingle;

            this.labelDescription.Location = new Point(20, 315);
            this.labelDescription.Size = new Size(460, 50);
            this.labelDescription.Font = new Font("Segoe UI", 10F);
            this.labelDescription.TextAlign = ContentAlignment.MiddleCenter;

            this.groupBoxPhoto.Controls.Add(this.labelDescription);
            this.groupBoxPhoto.Controls.Add(this.pictureBoxPhoto);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(580, 520);
            this.Controls.Add(this.groupBoxPhoto);
            this.Controls.Add(this.comboBoxPhotos);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "ФотоАльбом";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}