using System;
using TechSupport.Controller;
using System.Windows.Forms;

namespace TechSupport.View
{
    public partial class Search : Form
    {
        private readonly SearchController searchController;
        MainForm previousForm = null;
        public Search(MainForm previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.previousForm.Visible = false;
            this.searchController = new SearchController();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchGrid.DataSource = null;
            try
            {
                searchGrid.DataSource = this.searchController.GetIncidentsByCustomerID(int.Parse(searchTextBox.Text));
            }

            catch(FormatException ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                   "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
        }

        private void Search_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.previousForm.Visible = true;
        }
    }
}
