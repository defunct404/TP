using Microsoft.VisualBasic.Logging;
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
    public partial class CreateEventPopup : Form
    {
        public CreateEventPopup()
        {
            InitializeComponent();

            var controller = ManageClass.GetDatabaseController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //try
            this.Close();
        }

        public bool CheckStoragePermission()
        {
            Random random = new Random();
            bool hasStoragePermission = random.Next(2) == 0;

            if (hasStoragePermission)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckContactsPermission()
        {
            Random random = new Random();
            bool hasContactsPermission = random.Next(2) == 0;

            if (hasContactsPermission)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PersonNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void DateLabel_Click(object sender, EventArgs e)
        {

        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
