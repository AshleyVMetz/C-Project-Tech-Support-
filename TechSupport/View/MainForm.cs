using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    public partial class MainForm : Form
    {
        Form previousForm = null;
        private readonly AddIncidentController addIncidentController;
        

        public MainForm(string username, Form previousForm)
        {
            InitializeComponent();
            this.addIncidentController = new AddIncidentController();
            RefreshDataGrid();
            userNameLabelMain.Text = username;
            this.previousForm = previousForm;
        
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            previousForm.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.RefreshDataGrid();
        }

        public void RefreshDataGrid()
        {

            this.dataGridViewIncidents.DataSource = null;
            this.dataGridViewIncidents.DataSource = this.addIncidentController.GetIncidents();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            previousForm.Close();
        }

        private void addIncidentButton_Click(object sender, EventArgs e)
        {
           
            AddIncident addIncident = new AddIncident(this);
            addIncident.Show();
            
            this.RefreshDataGrid();
           
        }

        private void searchIncidentButton_Click(object sender, EventArgs e)
        {
            Search search = new Search(this);
            search.Show();
        }
    }
}
