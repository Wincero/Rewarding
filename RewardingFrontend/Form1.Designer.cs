namespace RewardingFrontend
{
    partial class RewardingForm
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
            dateLabel = new Label();
            deputyLabel = new Label();
            directorLabel = new Label();
            workerLabel = new Label();
            deputiesComboBox = new ComboBox();
            workersComboBox = new ComboBox();
            rewardTextBox = new TextBox();
            rewardLabel = new Label();
            saveButton = new Button();
            directorTextBox = new TextBox();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.Top;
            dateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            dateLabel.Location = new Point(232, 33);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(309, 51);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "Дата";
            dateLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // deputyLabel
            // 
            deputyLabel.AutoSize = true;
            deputyLabel.Location = new Point(12, 119);
            deputyLabel.Name = "deputyLabel";
            deputyLabel.Size = new Size(152, 32);
            deputyLabel.TabIndex = 1;
            deputyLabel.Text = "Заместитель";
            // 
            // directorLabel
            // 
            directorLabel.AutoSize = true;
            directorLabel.Location = new Point(12, 190);
            directorLabel.Name = "directorLabel";
            directorLabel.Size = new Size(167, 32);
            directorLabel.TabIndex = 2;
            directorLabel.Text = "Руководитель";
            directorLabel.Visible = false;
            // 
            // workerLabel
            // 
            workerLabel.AutoSize = true;
            workerLabel.Location = new Point(12, 263);
            workerLabel.Name = "workerLabel";
            workerLabel.Size = new Size(117, 32);
            workerLabel.TabIndex = 3;
            workerLabel.Text = "Работник";
            workerLabel.Visible = false;
            // 
            // deputiesComboBox
            // 
            deputiesComboBox.FormattingEnabled = true;
            deputiesComboBox.Location = new Point(170, 119);
            deputiesComboBox.Name = "deputiesComboBox";
            deputiesComboBox.Size = new Size(565, 40);
            deputiesComboBox.TabIndex = 4;
            // 
            // workersComboBox
            // 
            workersComboBox.FormattingEnabled = true;
            workersComboBox.Location = new Point(135, 263);
            workersComboBox.Name = "workersComboBox";
            workersComboBox.Size = new Size(600, 40);
            workersComboBox.TabIndex = 6;
            workersComboBox.Visible = false;
            // 
            // rewardTextBox
            // 
            rewardTextBox.Location = new Point(12, 385);
            rewardTextBox.Multiline = true;
            rewardTextBox.Name = "rewardTextBox";
            rewardTextBox.Size = new Size(723, 200);
            rewardTextBox.TabIndex = 8;
            rewardTextBox.Visible = false;
            // 
            // rewardLabel
            // 
            rewardLabel.AutoSize = true;
            rewardLabel.Location = new Point(12, 332);
            rewardLabel.Name = "rewardLabel";
            rewardLabel.Size = new Size(308, 32);
            rewardLabel.TabIndex = 9;
            rewardLabel.Text = "Введите текст поощрения:";
            rewardLabel.Visible = false;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(448, 613);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(287, 46);
            saveButton.TabIndex = 10;
            saveButton.Text = "Сохранить поощрение\r\n";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Visible = false;
            saveButton.Click += saveButton_Click;
            // 
            // directorTextBox
            // 
            directorTextBox.Location = new Point(185, 190);
            directorTextBox.Name = "directorTextBox";
            directorTextBox.Size = new Size(550, 39);
            directorTextBox.TabIndex = 11;
            directorTextBox.Visible = false;
            // 
            // RewardingForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 685);
            Controls.Add(directorTextBox);
            Controls.Add(saveButton);
            Controls.Add(rewardLabel);
            Controls.Add(rewardTextBox);
            Controls.Add(workersComboBox);
            Controls.Add(deputiesComboBox);
            Controls.Add(workerLabel);
            Controls.Add(directorLabel);
            Controls.Add(deputyLabel);
            Controls.Add(dateLabel);
            Name = "RewardingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Премирование";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dateLabel;
        private Label deputyLabel;
        private Label directorLabel;
        private Label workerLabel;
        private ComboBox deputiesComboBox;
        private ComboBox workersComboBox;
        private TextBox rewardTextBox;
        private Label rewardLabel;
        private Button saveButton;
        private TextBox directorTextBox;
    }
}
