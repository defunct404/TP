using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_lab3
{
    public partial class AddEvent : Form
    {
        public AddEvent()
        {
            InitializeComponent();
        }

        private void BackToGreetingsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            GreetingsForm form = new GreetingsForm();
            form.Show();
        }

        private void CreateEventButton_Click(object sender, EventArgs e)
        {
            var formPopup = new CreateEventPopup();
            formPopup.Show(this);
        }
    }
}
