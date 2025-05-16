namespace Phan1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            orderLabel = new Label();
            nameLabel = new Label();
            birthDateLabel = new Label();
            emailLabel = new Label();
            orderTextBox = new TextBox();
            nameTextBox = new TextBox();
            birthDateTextBox = new TextBox();
            emailTextBox = new TextBox();
            addButton = new Button();
            saveButton = new Button();
            exitButton = new Button();
            listView = new ListView();
            orderColumn = new ColumnHeader();
            nameColumn = new ColumnHeader();
            birthDateColumn = new ColumnHeader();
            emailColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Location = new Point(42, 42);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(39, 15);
            orderLabel.TabIndex = 0;
            orderLabel.Text = "Mã số";
            orderLabel.Click += label1_Click;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(38, 83);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(43, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Họ tên";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.Location = new Point(21, 123);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(60, 15);
            birthDateLabel.TabIndex = 2;
            birthDateLabel.Text = "Ngày sinh";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(45, 161);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email";
            // 
            // orderTextBox
            // 
            orderTextBox.Location = new Point(102, 34);
            orderTextBox.Name = "orderTextBox";
            orderTextBox.Size = new Size(470, 23);
            orderTextBox.TabIndex = 4;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(102, 75);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(470, 23);
            nameTextBox.TabIndex = 5;
            // 
            // birthDateTextBox
            // 
            birthDateTextBox.Location = new Point(102, 115);
            birthDateTextBox.Name = "birthDateTextBox";
            birthDateTextBox.Size = new Size(470, 23);
            birthDateTextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(102, 161);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(470, 23);
            emailTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(197, 213);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 8;
            addButton.Text = "Thêm";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(267, 213);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 9;
            saveButton.Text = "Lưu";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(338, 213);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 10;
            exitButton.Text = "Thoát";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // listView
            // 
            listView.AccessibleRole = AccessibleRole.None;
            listView.Columns.AddRange(new ColumnHeader[] { orderColumn, nameColumn, birthDateColumn, emailColumn });
            listView.Location = new Point(21, 252);
            listView.Name = "listView";
            listView.Size = new Size(551, 97);
            listView.TabIndex = 12;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // orderColumn
            // 
            orderColumn.Text = "Mã số";
            orderColumn.Width = 137;
            // 
            // nameColumn
            // 
            nameColumn.Text = "Họ tên";
            nameColumn.Width = 137;
            // 
            // birthDateColumn
            // 
            birthDateColumn.Text = "Ngày sinh";
            birthDateColumn.Width = 137;
            // 
            // emailColumn
            // 
            emailColumn.Text = "Email";
            emailColumn.Width = 137;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(listView);
            Controls.Add(exitButton);
            Controls.Add(saveButton);
            Controls.Add(addButton);
            Controls.Add(emailTextBox);
            Controls.Add(birthDateTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(orderTextBox);
            Controls.Add(emailLabel);
            Controls.Add(birthDateLabel);
            Controls.Add(nameLabel);
            Controls.Add(orderLabel);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label orderLabel;
        private Label nameLabel;
        private Label birthDateLabel;
        private Label emailLabel;
        private TextBox orderTextBox;
        private TextBox nameTextBox;
        private TextBox birthDateTextBox;
        private TextBox emailTextBox;
        private Button addButton;
        private Button saveButton;
        private Button exitButton;
        private ListView listView;
        private ColumnHeader orderColumn;
        private ColumnHeader nameColumn;
        private ColumnHeader birthDateColumn;
        private ColumnHeader emailColumn;
    }
}
