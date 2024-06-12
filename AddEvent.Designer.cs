namespace tp_lab3
{
    partial class AddEvent
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
            BackToGreetingsButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            eventUserControl1 = new EventUserControl();
            eventUserControl2 = new EventUserControl();
            eventUserControl3 = new EventUserControl();
            eventUserControl4 = new EventUserControl();
            eventUserControl5 = new EventUserControl();
            eventUserControl6 = new EventUserControl();
            CreateEventButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BackToGreetingsButton
            // 
            BackToGreetingsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BackToGreetingsButton.Location = new Point(40, 497);
            BackToGreetingsButton.Name = "BackToGreetingsButton";
            BackToGreetingsButton.Size = new Size(194, 54);
            BackToGreetingsButton.TabIndex = 2;
            BackToGreetingsButton.Text = "Назад";
            BackToGreetingsButton.UseVisualStyleBackColor = true;
            BackToGreetingsButton.Click += BackToGreetingsButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(eventUserControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(eventUserControl2, 0, 1);
            tableLayoutPanel1.Controls.Add(eventUserControl3, 0, 2);
            tableLayoutPanel1.Controls.Add(eventUserControl4, 0, 3);
            tableLayoutPanel1.Controls.Add(eventUserControl5, 0, 4);
            tableLayoutPanel1.Controls.Add(eventUserControl6, 0, 5);
            tableLayoutPanel1.Location = new Point(2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(265, 414);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // eventUserControl1
            // 
            eventUserControl1.Location = new Point(3, 3);
            eventUserControl1.Name = "eventUserControl1";
            eventUserControl1.Size = new Size(210, 100);
            eventUserControl1.TabIndex = 0;
            // 
            // eventUserControl2
            // 
            eventUserControl2.Location = new Point(3, 109);
            eventUserControl2.Name = "eventUserControl2";
            eventUserControl2.Size = new Size(210, 100);
            eventUserControl2.TabIndex = 1;
            // 
            // eventUserControl3
            // 
            eventUserControl3.Location = new Point(3, 215);
            eventUserControl3.Name = "eventUserControl3";
            eventUserControl3.Size = new Size(210, 100);
            eventUserControl3.TabIndex = 2;
            // 
            // eventUserControl4
            // 
            eventUserControl4.Location = new Point(3, 321);
            eventUserControl4.Name = "eventUserControl4";
            eventUserControl4.Size = new Size(210, 100);
            eventUserControl4.TabIndex = 3;
            // 
            // eventUserControl5
            // 
            eventUserControl5.Location = new Point(3, 427);
            eventUserControl5.Name = "eventUserControl5";
            eventUserControl5.Size = new Size(210, 100);
            eventUserControl5.TabIndex = 4;
            // 
            // eventUserControl6
            // 
            eventUserControl6.Location = new Point(3, 533);
            eventUserControl6.Name = "eventUserControl6";
            eventUserControl6.Size = new Size(210, 100);
            eventUserControl6.TabIndex = 5;
            // 
            // CreateEventButton
            // 
            CreateEventButton.Location = new Point(40, 437);
            CreateEventButton.Name = "CreateEventButton";
            CreateEventButton.Size = new Size(194, 54);
            CreateEventButton.TabIndex = 4;
            CreateEventButton.Text = "Создать";
            CreateEventButton.UseVisualStyleBackColor = true;
            CreateEventButton.Click += CreateEventButton_Click;
            // 
            // AddEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 559);
            Controls.Add(CreateEventButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(BackToGreetingsButton);
            Name = "AddEvent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEvent";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button EventsButton;
        private Button BackToGreetingsButton;
        private TableLayoutPanel tableLayoutPanel1;
        private EventUserControl eventUserControl1;
        private EventUserControl eventUserControl2;
        private EventUserControl eventUserControl3;
        private Button CreateEventButton;
        private EventUserControl eventUserControl4;
        private EventUserControl eventUserControl5;
        private EventUserControl eventUserControl6;
    }
}