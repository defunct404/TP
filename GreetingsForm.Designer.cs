namespace tp_lab3
{
    partial class GreetingsForm
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
            CardsButton = new Button();
            EventsButton = new Button();
            EventsTodayLabel = new Label();
            SendCardButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            eventUserControl1 = new EventUserControl();
            ErrorLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // CardsButton
            // 
            CardsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CardsButton.Location = new Point(40, 497);
            CardsButton.Name = "CardsButton";
            CardsButton.Size = new Size(194, 54);
            CardsButton.TabIndex = 0;
            CardsButton.Text = "Открытки";
            CardsButton.UseVisualStyleBackColor = true;
            CardsButton.Click += CardsButton_Click;
            // 
            // EventsButton
            // 
            EventsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EventsButton.Location = new Point(40, 437);
            EventsButton.Name = "EventsButton";
            EventsButton.Size = new Size(194, 54);
            EventsButton.TabIndex = 1;
            EventsButton.Text = "События";
            EventsButton.UseVisualStyleBackColor = true;
            EventsButton.Click += EventsButton_Click;
            // 
            // EventsTodayLabel
            // 
            EventsTodayLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EventsTodayLabel.AutoSize = true;
            EventsTodayLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            EventsTodayLabel.Location = new Point(49, 13);
            EventsTodayLabel.Name = "EventsTodayLabel";
            EventsTodayLabel.Size = new Size(148, 19);
            EventsTodayLabel.TabIndex = 2;
            EventsTodayLabel.Text = "Праздники сегодня";
            // 
            // SendCardButton
            // 
            SendCardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SendCardButton.Location = new Point(0, 391);
            SendCardButton.Name = "SendCardButton";
            SendCardButton.Size = new Size(265, 40);
            SendCardButton.TabIndex = 0;
            SendCardButton.Text = "Поздравить другого";
            SendCardButton.UseVisualStyleBackColor = true;
            SendCardButton.Click += SendCardButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(eventUserControl1, 0, 0);
            tableLayoutPanel1.Location = new Point(-3, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(268, 383);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // eventUserControl1
            // 
            eventUserControl1.Location = new Point(4, 4);
            eventUserControl1.Name = "eventUserControl1";
            eventUserControl1.Size = new Size(210, 100);
            eventUserControl1.TabIndex = 0;
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 7F);
            ErrorLabel.Location = new Point(1, 1);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(148, 12);
            ErrorLabel.TabIndex = 9;
            ErrorLabel.Text = "Выберите одну из опций ниже";
            // 
            // GreetingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 559);
            Controls.Add(ErrorLabel);
            Controls.Add(SendCardButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(EventsTodayLabel);
            Controls.Add(EventsButton);
            Controls.Add(CardsButton);
            Name = "GreetingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GreetingsForm";
            Load += GreetingsForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CardsButton;
        private Button EventsButton;
        private Label EventsTodayLabel;
        private Button SendCardButton;
        private TableLayoutPanel tableLayoutPanel1;
        private EventUserControl eventUserControl1;
        private Label ErrorLabel;
    }
}