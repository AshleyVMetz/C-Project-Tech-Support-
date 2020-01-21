using System.Collections.Generic;
using TechSupport.Model;
using TechSupport.DAL;
using System.Windows.Forms;

namespace TechSupport.Controller
{
    class SearchController
    {
        private IncidentDAL incidentSource;

        public SearchController()
        {
            this.incidentSource = new IncidentDAL();
        }

        public List<Incident> GetIncidentsByCustomerID(int customerID)
        {
            if  (this.incidentSource.GetIncidentsByCustomerID(customerID).Count == 0)
            {
                MessageBox.Show("Customer does not exist",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return this.incidentSource.GetIncidentsByCustomerID(customerID);
           
        }
    }
}






