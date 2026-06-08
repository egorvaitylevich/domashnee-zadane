using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TodoListApp
{
    public partial class Form1 : Form
    {
        private List<TodoItem> todoItems = new List<TodoItem>();

        public Form1()
        {
            InitializeComponent();
            UpdateListBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string text = txtNewTask.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Введите текст задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            todoItems.Add(new TodoItem { Title = text, IsCompleted = false });
            txtNewTask.Clear();
            UpdateListBox();
            txtNewTask.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (checkedListBoxTodo.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите задачу для удаления!", "Внимание");
                return;
            }

            todoItems.RemoveAt(checkedListBoxTodo.SelectedIndex);
            UpdateListBox();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить все задачи?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                todoItems.Clear();
                UpdateListBox();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkedListBoxTodo.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите задачу для изменения!", "Внимание");
                return;
            }

            int index = checkedListBoxTodo.SelectedIndex;
            string newTitle = Microsoft.VisualBasic.Interaction.InputBox("Введите новое название задачи:", "Редактирование задачи", todoItems[index].Title);

            if (!string.IsNullOrEmpty(newTitle?.Trim()))
            {
                todoItems[index].Title = newTitle.Trim();
                UpdateListBox();
            }
        }

        private void btnToggleComplete_Click(object sender, EventArgs e)
        {
            if (checkedListBoxTodo.SelectedIndex == -1) return;

            int index = checkedListBoxTodo.SelectedIndex;
            todoItems[index].IsCompleted = !todoItems[index].IsCompleted;
            UpdateListBox();
        }

        private void checkedListBoxTodo_DoubleClick(object sender, EventArgs e)
        {
            if (checkedListBoxTodo.SelectedIndex != -1)
            {
                int index = checkedListBoxTodo.SelectedIndex;
                todoItems[index].IsCompleted = !todoItems[index].IsCompleted;
                UpdateListBox();
            }
        }

        private void UpdateListBox()
        {
            checkedListBoxTodo.Items.Clear();

            foreach (var item in todoItems)
            {
                checkedListBoxTodo.Items.Add(item.Title, item.IsCompleted);
            }
        }

        public class TodoItem
        {
            public string Title { get; set; }
            public bool IsCompleted { get; set; }
        }
    }
}