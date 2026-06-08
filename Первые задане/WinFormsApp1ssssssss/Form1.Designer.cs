namespace TodoListApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtNewTask;
        private Button btnAdd;
        private CheckedListBox checkedListBoxTodo;
        private Button btnDelete;
        private Button btnDeleteAll;
        private Button btnEdit;
        private Button btnToggleComplete;
        private Label labelTitle;

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
            this.txtNewTask = new TextBox();
            this.btnAdd = new Button();
            this.checkedListBoxTodo = new CheckedListBox();
            this.btnDelete = new Button();
            this.btnDeleteAll = new Button();
            this.btnEdit = new Button();
            this.btnToggleComplete = new Button();

            this.SuspendLayout();

            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.labelTitle.Location = new Point(20, 20);
            this.labelTitle.Text = "Todo List";

            this.txtNewTask.Location = new Point(20, 70);
            this.txtNewTask.Size = new Size(400, 30);
            this.txtNewTask.Font = new Font("Segoe UI", 11F);
            this.txtNewTask.PlaceholderText = "Введите новую задачу...";

            this.btnAdd.Location = new Point(430, 68);
            this.btnAdd.Size = new Size(100, 35);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            this.checkedListBoxTodo.Location = new Point(20, 120);
            this.checkedListBoxTodo.Size = new Size(510, 280);
            this.checkedListBoxTodo.Font = new Font("Segoe UI", 11F);
            this.checkedListBoxTodo.CheckOnClick = true;
            this.checkedListBoxTodo.DoubleClick += new EventHandler(this.checkedListBoxTodo_DoubleClick); // ← Изменено имя

            this.btnToggleComplete.Location = new Point(20, 420);
            this.btnToggleComplete.Size = new Size(130, 40);
            this.btnToggleComplete.Text = "Выполнено";
            this.btnToggleComplete.Click += new EventHandler(this.btnToggleComplete_Click);

            this.btnEdit.Location = new Point(160, 420);
            this.btnEdit.Size = new Size(110, 40);
            this.btnEdit.Text = "Изменить";
            this.btnEdit.Click += new EventHandler(this.btnEdit_Click);

            this.btnDelete.Location = new Point(280, 420);
            this.btnDelete.Size = new Size(110, 40);
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            this.btnDeleteAll.Location = new Point(400, 420);
            this.btnDeleteAll.Size = new Size(130, 40);
            this.btnDeleteAll.Text = "Удалить всё";
            this.btnDeleteAll.Click += new EventHandler(this.btnDeleteAll_Click);

            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(560, 480);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnToggleComplete);
            this.Controls.Add(this.checkedListBoxTodo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewTask);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Todo List";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}