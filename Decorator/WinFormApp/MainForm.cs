using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DecoratorExample;

namespace WinFormApp
{
    public partial class MainForm : Form
    {
        BindingList<Person> _personList;

        public MainForm()
        {
            InitializeComponent();

            // Create binding list
            var personList = new List<Person>();

            // Add xml logging, passing BindingList
            var xmlLoggingList = new XmlLoggingDecorator<Person>(personList);

            // Add json logging, passing XmlLoggingCollection
            var jsonLoggingList = new JsonLoggingDecorator<Person>(xmlLoggingList);

            // Bind list to data grid
            _personList = new BindingList<Person>(jsonLoggingList);
            personBindingSource.DataSource = _personList;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var person = new Person
            {
                Name = nameTextBox.Text,
                Age = int.Parse(ageTextBox.Text)
            };
            _personList.Add(person);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var person = (Person)personBindingSource.Current;
            if (person == null) return;
            _personList.Remove(person);
        }
    }
}
