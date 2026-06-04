using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeEvents();
            UpdateColor();
        }

        private void InitializeEvents()
        {
            trackBarRed.ValueChanged += TrackBar_ValueChanged;
            trackBarGreen.ValueChanged += TrackBar_ValueChanged;
            trackBarBlue.ValueChanged += TrackBar_ValueChanged;
        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {
            UpdateColor();
        }

        private void UpdateColor()
        {
            int r = trackBarRed.Value;
            int g = trackBarGreen.Value;
            int b = trackBarBlue.Value;

            Color currentColor = Color.FromArgb(r, g, b);

            colorPanel.BackColor = currentColor;

            lblValueRed.Text = r.ToString();
            lblValueGreen.Text = g.ToString();
            lblValueBlue.Text = b.ToString();

            UpdateHex(currentColor);
        }

        private void UpdateHex(Color color)
        {
            lblHex.Text = ColorToHex(color);
        }

        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        private void btnGetHex_Click(object sender, EventArgs e)
        {
            string hex = lblHex.Text;

            Clipboard.SetText(hex);

            MessageBox.Show($"HEX код: {hex}\n\nСкопировано в буфер обмена!",
                            "Успешно",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.FullOpen = true;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;

                    trackBarRed.Value = selectedColor.R;
                    trackBarGreen.Value = selectedColor.G;
                    trackBarBlue.Value = selectedColor.B;

                    UpdateColor();
                }
            }
        }
    }
}