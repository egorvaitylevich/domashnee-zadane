namespace ColorPicker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private Label lblValueRed;
        private Label lblValueGreen;
        private Label lblValueBlue;
        private Panel colorPanel;
        private Button btnPickColor;
        private Label lblTitle;

        private Button btnGetHex;
        private Label lblHexTitle;
        private Label lblHex;

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
            this.trackBarRed = new TrackBar();
            this.trackBarGreen = new TrackBar();
            this.trackBarBlue = new TrackBar();
            this.lblRed = new Label();
            this.lblGreen = new Label();
            this.lblBlue = new Label();
            this.lblValueRed = new Label();
            this.lblValueGreen = new Label();
            this.lblValueBlue = new Label();
            this.colorPanel = new Panel();
            this.btnPickColor = new Button();
            this.lblTitle = new Label();

            this.btnGetHex = new Button();
            this.lblHexTitle = new Label();
            this.lblHex = new Label();

            ((System.ComponentModel.ISupportInitialize)this.trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.trackBarBlue).BeginInit();
            this.SuspendLayout();

            this.trackBarRed.Location = new System.Drawing.Point(50, 80);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(250, 45);
            this.trackBarRed.TabIndex = 0;

            this.trackBarGreen.Location = new System.Drawing.Point(50, 140);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(250, 45);
            this.trackBarGreen.TabIndex = 1;

            this.trackBarBlue.Location = new System.Drawing.Point(50, 200);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(250, 45);
            this.trackBarBlue.TabIndex = 2;

            this.lblRed.Location = new System.Drawing.Point(0, 85);
            this.lblRed.Text = "Красный:";
            this.lblRed.AutoSize = true;

            this.lblGreen.Location = new System.Drawing.Point(0, 145);
            this.lblGreen.Text = "Зелёный:";
            this.lblGreen.AutoSize = true;

            this.lblBlue.Location = new System.Drawing.Point(0, 205);
            this.lblBlue.Text = "Синий:";
            this.lblBlue.AutoSize = true;

            this.lblValueRed.Location = new System.Drawing.Point(310, 85);
            this.lblValueRed.Text = "0";
            this.lblValueRed.AutoSize = true;

            this.lblValueGreen.Location = new System.Drawing.Point(310, 145);
            this.lblValueGreen.Text = "0";
            this.lblValueGreen.AutoSize = true;

            this.lblValueBlue.Location = new System.Drawing.Point(310, 205);
            this.lblValueBlue.Text = "0";
            this.lblValueBlue.AutoSize = true;

            this.colorPanel.Location = new System.Drawing.Point(400, 80);
            this.colorPanel.Size = new System.Drawing.Size(150, 150);
            this.colorPanel.BorderStyle = BorderStyle.FixedSingle;

            this.btnPickColor.Location = new System.Drawing.Point(400, 250);
            this.btnPickColor.Size = new System.Drawing.Size(150, 40);
            this.btnPickColor.Text = "Выбрать цвет";
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);

            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Простой Color Picker";
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.AutoSize = true;

            this.lblHexTitle.Location = new System.Drawing.Point(20, 270);
            this.lblHexTitle.Text = "HEX:";
            this.lblHexTitle.AutoSize = true;
            this.lblHexTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);

            this.lblHex.Location = new System.Drawing.Point(70, 268);
            this.lblHex.Text = "#000000";
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Consolas", 11.5F);
            this.lblHex.BorderStyle = BorderStyle.FixedSingle;
            this.lblHex.Padding = new Padding(6, 4, 6, 4);

            this.ClientSize = new System.Drawing.Size(580, 360);
            this.Controls.Add(this.lblHexTitle);
            this.Controls.Add(this.lblHex);
            this.Controls.Add(this.btnGetHex);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPickColor);
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.lblValueBlue);
            this.Controls.Add(this.lblValueGreen);
            this.Controls.Add(this.lblValueRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.trackBarRed);

            this.Name = "Form1";
            this.StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)this.trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.trackBarBlue).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}