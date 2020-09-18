using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfishA
{
    public partial class EventForm : Form
    {
        public EventForm(string eventKey)
        {
            nameLabel.Text = Main.EventList[eventKey].Name;
            descrtiptionTextBox.Text = Main.EventList[eventKey].Description;

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
