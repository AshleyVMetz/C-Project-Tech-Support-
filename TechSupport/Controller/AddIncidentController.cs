using TechSupport.DAL;
using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.Controller
{
    public class AddIncidentController
    {
        private IncidentDAL incidentSource;

        public AddIncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

        public List<Incident> GetIncidents()
        {
        return this.incidentSource.GetIncidents();
        }

        
        public void Add(Incident incident)
        {

            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            this.incidentSource.Add(incident);

        }
    }
}

      

