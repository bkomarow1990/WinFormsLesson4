using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsHW
{
    public partial class EditEventForm : Form
    {
        WorkWithJsonEvent jsonworker = new WorkWithJsonEvent("Events.json");
        public ListBox events_ = new ListBox();
        Form1 form1;
        public EditEventForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void EditEventForm_Load(object sender, EventArgs e)
        {
            Event ev = events_.SelectedItem as Event;
            this.nameTxtBox.Text = ev.Name;
            this.placeTextBox.Text = ev.Place;
            this.dateTimePicker1.Value = ev.Time;
            this.typeEventComboBox.DataSource = Enum.GetValues(typeof(Event.Priorities));
            this.typeEventComboBox.SelectedItem = ev.Priority;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Event tmp = new Event();
            tmp.Name = this.nameTxtBox.Text;
            tmp.Place = this.placeTextBox.Text;
            tmp.Priority = (Event.Priorities)this.typeEventComboBox.SelectedItem;
            tmp.Time = this.dateTimePicker1.Value;
            List<Event> events = new List<Event>(events_.Items.Cast<Event>());
            events[this.events_.SelectedIndex] = tmp;
            form1.jsonworker.Export(events);
            form1.Import();
            MessageBox.Show("Edited");
            this.Close();
        }
    }
}
