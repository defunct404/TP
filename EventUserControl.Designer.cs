namespace tp_lab3
{
    partial class EventUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DateLabel = new Label();
            EventNameLabel = new Label();
            PersonNameLabel = new Label();
            SendCardButton = new Button();
            SuspendLayout();
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(3, 9);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(62, 15);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "Дата: Date";
            // 
            // EventNameLabel
            // 
            EventNameLabel.AutoSize = true;
            EventNameLabel.Location = new Point(3, 30);
            EventNameLabel.Name = "EventNameLabel";
            EventNameLabel.Size = new Size(91, 15);
            EventNameLabel.TabIndex = 1;
            EventNameLabel.Text = "Событие: Event";
            // 
            // PersonNameLabel
            // 
            PersonNameLabel.AutoSize = true;
            PersonNameLabel.Location = new Point(3, 49);
            PersonNameLabel.Name = "PersonNameLabel";
            PersonNameLabel.Size = new Size(138, 15);
            PersonNameLabel.TabIndex = 2;
            PersonNameLabel.Text = "Празднует: PersonName";
            // 
            // SendCardButton
            // 
            SendCardButton.Location = new Point(3, 67);
            SendCardButton.Name = "SendCardButton";
            SendCardButton.Size = new Size(204, 30);
            SendCardButton.TabIndex = 3;
            SendCardButton.Text = "Поздравить";
            SendCardButton.UseVisualStyleBackColor = true;
            // 
            // EventUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SendCardButton);
            Controls.Add(PersonNameLabel);
            Controls.Add(EventNameLabel);
            Controls.Add(DateLabel);
            Name = "EventUserControl";
            Size = new Size(210, 100);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateLabel;
        private Label EventNameLabel;
        private Label PersonNameLabel;
        private Button SendCardButton;
    }
}
