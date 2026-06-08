using System;
using System.Drawing;
using System.Windows.Forms;

namespace PhotoAlbum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPhotos();
            comboBoxPhotos.SelectedIndex = 0;
        }

        private void LoadPhotos()
        {
            comboBoxPhotos.Items.Add("Горный пейзаж");
            comboBoxPhotos.Items.Add("Нью-Йорк ночью");
            comboBoxPhotos.Items.Add("Море на закате");
            comboBoxPhotos.Items.Add("Лесной туман");
            comboBoxPhotos.Items.Add("Озеро в горах");
        }

        private void comboBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPhotos.SelectedIndex == -1) return;

            switch (comboBoxPhotos.SelectedIndex)
            {
                case 0:
                    pictureBoxPhoto.Image = Image.FromFile(@"C:\Users\Колледж\source\repos\na github\Второэ\WinFormsApp1ssssssss\котак с бассом.png");
                    labelDescription.Text = "Горный пейзаж в Альпах. Осень 2025.";
                    break;

                case 1:
                    pictureBoxPhoto.Image = Image.FromFile(@"C:\Users\Колледж\source\repos\na github\Второэ\WinFormsApp1ssssssss\котак с бассом.png");
                    labelDescription.Text = "Ночной Нью-Йорк. Вид с Empire State Building.";
                    break;

                case 2:
                    pictureBoxPhoto.Image = Image.FromFile(@"C:\Users\Колледж\source\repos\na github\Второэ\WinFormsApp1ssssssss\котак с бассом.png");
                    labelDescription.Text = "Закат над Чёрным морем. Сочи, Россия.";
                    break;

                case 3:
                    pictureBoxPhoto.Image = Image.FromFile(@"C:\Users\Колледж\source\repos\na github\Второэ\WinFormsApp1ssssssss\котак с бассом.png");
                    labelDescription.Text = "Туманный лес ранним утром.";
                    break;

                case 4:
                    pictureBoxPhoto.Image = Image.FromFile(@"C:\Users\Колледж\source\repos\na github\Второэ\WinFormsApp1ssssssss\котак с бассом.png");
                    labelDescription.Text = "Горное озеро в солнечный день.";
                    break;
            }
        }
    }
}