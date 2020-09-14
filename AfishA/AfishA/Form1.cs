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
    public partial class Form1 : Form
    {
        public List<Event> EventList = new List<Event>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sortComboBox.SelectedIndex = 0;

            //mainPanel.Controls.Add(null);

            foreach(var _event in EventList)
            {
                _event.Button.Click += DetailedButton_Click;
            }
        }

        private void DetailedButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public struct Event
    {
        public Button Button;
    }
}
