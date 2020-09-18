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
    public partial class Main : Form
    {
        public static Dictionary<string, Event> EventList = new Dictionary<string, Event>();

        public Main()
        {
            EventList.Add("Default", new Event("Name", "Description", "DetailedDescription", "City.Adress", -1, DateTime.Today.AddDays(7), new List<Ticket>(), Image.FromFile("kartinochki/уандэй.jpg"), "Default"));

            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sortComboBox.SelectedIndex = 0;

            mainPanel.Controls.Add(EventList["Default"].Panel);
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public struct Event
    {
        public string Name;
        public string Description;
        public string DetailedDescription;
        public string Address;

        public int AgeLimit;

        public DateTime DateTime;
        public List<Ticket> Tickets;
        public Image Image;

        public Panel Panel;
        private Label placeLabel, dateLabel, nameLabel;
        private PictureBox pictureBox;
        private Button button;

        public Event(string name, string description, string detailedDescription, string address, int ageLimit, DateTime dateTime, List<Ticket> tickets, Image image, string key)
        {
            Name = name;
            Description = description;
            DetailedDescription = detailedDescription;
            Address = address;
            AgeLimit = ageLimit;
            DateTime = dateTime;
            Tickets = tickets;
            Image = image;

            placeLabel = new Label();
            placeLabel.Dock = DockStyle.Top;
            placeLabel.Text = "Место: " + Address; //тут можно если в том же городе то выводить адрес, а если в другом городе, то только город

            dateLabel = new Label();
            dateLabel.Dock = DockStyle.Top;
            dateLabel.Text = "Дата: " + DateTime.ToString("d");

            pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Image;

            nameLabel = new Label();
            nameLabel.Dock = DockStyle.Bottom;
            nameLabel.Text = Name;

            button = new Button();
            button.Dock = DockStyle.Bottom;
            button.Text = "Подробнее";
            button.Tag = key;
            
            Panel = new Panel();

            Panel.Size = new Size(238, 384);
            Panel.Controls.Add(placeLabel);
            Panel.Controls.Add(dateLabel);
            Panel.Controls.Add(pictureBox);
            Panel.Controls.Add(nameLabel); 
            Panel.Controls.Add(button);

            button.Click += DetailedButton_Click;
        }

        private void DetailedButton_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(((Control)sender).Tag.ToString());

            eventForm.Show();
        }
    }

    public struct Ticket
    {
        public int Prise;

        public TicketType Type;
    }

    public enum TicketType { Cheap, Expensive }
}
