using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace tp_lab3
{
    public partial class GreetingsForm : Form
    {
        public GreetingsForm()
        {
            InitializeComponent();
        }

        private void GreetingsForm_Load(object sender, EventArgs e)
        {
            //tableLayoutPanel1.HorizontalScroll.Maximum = 0;
            //tableLayoutPanel1.HorizontalScroll.Enabled = false;
            //tableLayoutPanel1.HorizontalScroll.Visible = false;
        }

        /// <summary>
        /// Отображение диалогового окна и строки состояния с надписью о нажатии кнопки "События"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventsButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";

            try
            {
                ErrorLabel.Text = "Нажато События";

                if (MessageBox.Show("Нажато События") == DialogResult.OK)
                {
                    this.Hide();
                    AddEvent form = new AddEvent();
                    form.Show();
                }
            }
            catch (Exception exception)
            {
                ErrorLabel.Text = exception.Message;
            }
        }

        /// <summary>
        /// Отображение диалогового окна и строки состояния с надписью о нажатии кнопки "Поздравить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendCardButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";

            try
            {
                ErrorLabel.Text = "Нажато Поздравить другого";

                if (MessageBox.Show("Нажато Поздравить другого") == DialogResult.OK)
                {
                    this.Hide();
                    AddEvent form = new AddEvent();
                    form.Show();
                }
            }
            catch (Exception exception)
            {
                ErrorLabel.Text = exception.Message;
            }
        }

        /// <summary>
        /// Отображение диалогового окна и строки состояния с надписью о нажатии кнопки "Открытки"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardsButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";

            try
            {
                ErrorLabel.Text = "Нажато Открытки";

                if (MessageBox.Show("Нажато Открытки") == DialogResult.OK)
                {
                    this.Hide();
                    AddEvent form = new AddEvent();
                    form.Show();
                }
            }
            catch (Exception exception)
            {
                ErrorLabel.Text = exception.Message;
            }
        }
    }
}
