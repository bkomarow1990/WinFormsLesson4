using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace EventsHW
{
    public partial class Form1 : Form
    {
        public WorkWithJsonEvent jsonworker = new WorkWithJsonEvent("Events.json");
        public Form1()
        {
            InitializeComponent();
        }
        public void Import()
        {
            eventsListBox.Items.Clear();
            this.eventsListBox.Items.AddRange(jsonworker.Import().ToArray());
        }
        public void AddComboBoxElems()
        {
            this.typeEventComboBox.DataSource = Enum.GetValues(typeof(Event.Priorities));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AddComboBoxElems();
            Import();
            //this.eventsListBox.Items.AddRange(jsonworker.Import().ToArray());
            //this.typeEventComboBox.Items.AddRange((object[])Enum.GetValues(typeof(Event.Priorities)));
        }

        private void typeEventComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            try { 
                Event event1 = new Event(this.nameTxtBox.Text,this.placeTextBox.Text,this.dateTimePicker1.Value, (Event.Priorities)typeEventComboBox.SelectedItem);
               
                if (eventsListBox.Items.Count > 0)
                {
                    List<Event> elems = new List<Event>(eventsListBox.Items.Cast<Event>());
                    if (elems.Any(e => e?.Name == event1.Name))
                    {
                        throw new ApplicationException("Event with same name alredy exists");
                    }
                }
                
                this.eventsListBox.Items.Add(event1);
                List<Event> events = new List<Event>(eventsListBox.Items.Cast<Event>());
                this.jsonworker.Export(events);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Debug.WriteLine(ex.Message);
                return;
            }
        }

        private void deleteSelectedBtn_Click(object sender, EventArgs e)
        {
            if (eventsListBox.Items.Count <= 0  )
            {
                MessageBox.Show("Haven`t events","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (eventsListBox.SelectedItems == null)
            {
                MessageBox.Show("Select item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            List<Event> willdeleted = new List<Event>(eventsListBox.SelectedItems.Cast<Event>());
            foreach (var item in willdeleted)
            {
                this.eventsListBox.Items.Remove(item);
            }
                List<Event> events = new List<Event>(eventsListBox.Items.Cast<Event>());
                this.jsonworker.Export(events);
        }

        private void editSelectedBtn_Click(object sender, EventArgs e)
        {
            if (eventsListBox.Items.Count <= 0)
            {
                MessageBox.Show("Haven`t events", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (eventsListBox.SelectedItem == null)
            {
                MessageBox.Show("Select item to delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EditEventForm editform = new EditEventForm(this);
            editform.events_ = eventsListBox;
            
            //this.Hide();
            editform.Show();
            //this.Hide();
            //this.jsonworker.Import();
        }
    }
}
