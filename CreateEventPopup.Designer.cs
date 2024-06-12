namespace tp_lab3
{
    partial class CreateEventPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PersonNameLabel = new Label();
            EventNameLabel = new Label();
            DateLabel = new Label();
            BackButton = new Button();
            SaveButton = new Button();
            ErrorLabelPopup = new Label();
            SuspendLayout();
            // 
            // PersonNameLabel
            // 
            PersonNameLabel.AutoSize = true;
            PersonNameLabel.Location = new Point(52, 64);
            PersonNameLabel.Name = "PersonNameLabel";
            PersonNameLabel.Size = new Size(138, 15);
            PersonNameLabel.TabIndex = 5;
            PersonNameLabel.Text = "Празднует: PersonName";
            PersonNameLabel.Click += PersonNameLabel_Click;
            // 
            // EventNameLabel
            // 
            EventNameLabel.AutoSize = true;
            EventNameLabel.Location = new Point(52, 45);
            EventNameLabel.Name = "EventNameLabel";
            EventNameLabel.Size = new Size(91, 15);
            EventNameLabel.TabIndex = 4;
            EventNameLabel.Text = "Событие: Event";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(52, 24);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(62, 15);
            DateLabel.TabIndex = 3;
            DateLabel.Text = "Дата: Date";
            DateLabel.Click += DateLabel_Click;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(2, 85);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(90, 28);
            BackButton.TabIndex = 6;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += button1_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(102, 85);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(90, 28);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ErrorLabelPopup
            // 
            ErrorLabelPopup.AutoSize = true;
            ErrorLabelPopup.Font = new Font("Segoe UI", 7F);
            ErrorLabelPopup.Location = new Point(2, 3);
            ErrorLabelPopup.Name = "ErrorLabelPopup";
            ErrorLabelPopup.Size = new Size(148, 12);
            ErrorLabelPopup.TabIndex = 8;
            ErrorLabelPopup.Text = "Выберите одну из опций ниже";
            ErrorLabelPopup.Click += ErrorLabel_Click;
            // 
            // CreateEventPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(194, 117);
            Controls.Add(ErrorLabelPopup);
            Controls.Add(SaveButton);
            Controls.Add(BackButton);
            Controls.Add(PersonNameLabel);
            Controls.Add(EventNameLabel);
            Controls.Add(DateLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateEventPopup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateEventPopup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PersonNameLabel;
        private Label EventNameLabel;
        private Label DateLabel;
        private Button BackButton;
        private Button SaveButton;
        private Label ErrorLabelPopup;
    }
}