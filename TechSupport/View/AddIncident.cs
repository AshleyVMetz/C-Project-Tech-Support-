using System;
using TechSupport.Model;
using TechSupport.Controller;
using System.Windows.Forms;

namespace TechSupport.View
{

    public partial class AddIncident : Form
    {
        private readonly AddIncidentController addIncidentController;
        MainForm previousForm = null;

        public AddIncident(MainForm previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.previousForm.Visible = false;
            this.addIncidentController = new AddIncidentController();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                var title = this.titleTextBox.Text;
                var description = this.DescriptionTextBox.Text;
                var customerID = int.Parse(this.customerIDTextBox.Text);

                this.addIncidentController.Add(new Incident(title, description, customerID));

                previousForm.RefreshDataGrid();
                this.Close();
                previousForm.Visible = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something is wrong with the input!!!!" + Environment.NewLine + ex.Message,
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.previousForm.Visible = true;
        }

        private void AddIncident_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.previousForm.Visible = true;
        }
    }

}