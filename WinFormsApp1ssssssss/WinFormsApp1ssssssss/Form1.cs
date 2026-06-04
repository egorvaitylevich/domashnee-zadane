using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1ssssssss
{
    public partial class Form1 : Form
    {
        private bool isMuted = false;
        private int previousVolume = 50;

        public Form1()
        {
            InitializeComponent();
            UpdateVolumeDisplay();
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            if (isMuted) return;

            UpdateVolumeDisplay();
            SimulateSound();
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            isMuted = !isMuted;

            if (isMuted)
            {
                previousVolume = trackBarVolume.Value;
                trackBarVolume.Value = 0;
                trackBarVolume.Enabled = false;
                buttonMute.Text = "включити звук";
                buttonMute.BackColor = Color.LightCoral;
            }
            else
            {
                trackBarVolume.Value = previousVolume;
                trackBarVolume.Enabled = true;
                buttonMute.Text = "выучилючил звук";
                buttonMute.BackColor = SystemColors.Control;
            }

            UpdateVolumeDisplay();
        }

        private void UpdateVolumeDisplay()
        {
            int volume = trackBarVolume.Value;

            labelVolume.Text = isMuted ? "Громкость: Выключено" : $"Громкость: {volume}%";

            if (isMuted || volume == 0)
            {
                pictureBoxSpeaker.Text = "звуко нет";
                pictureBoxSpeaker.ForeColor = Color.Gray;
            }
            else if (volume < 30)
            {
                pictureBoxSpeaker.Text = "звук немнога";
                pictureBoxSpeaker.ForeColor = Color.LightBlue;
            }
            else if (volume < 70)
            {
                pictureBoxSpeaker.Text = "звуко еще немнога";
                pictureBoxSpeaker.ForeColor = Color.DodgerBlue;
            }
            else
            {
                pictureBoxSpeaker.Text = "звук много";
                pictureBoxSpeaker.ForeColor = Color.Blue;
            }
        }

        private void SimulateSound()
        {
            if (isMuted || trackBarVolume.Value == 0) return;

            int volume = trackBarVolume.Value;
            int frequency = 400 + (volume * 8);
            int duration = 30 + (volume / 2);

            try
            {
                Console.Beep(frequency, duration);
            }
            catch { }
        }
    }
}