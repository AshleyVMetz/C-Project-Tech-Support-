using TechSupport.Model;
using System;
using System.Collections.Generic;


namespace TechSupport.DAL
{
    public class IncidentDAL
    {

        private static List<Incident> incidents = new List<Incident>(); 
        


    public List<Incident> GetIncidents()
    {
        return incidents;
    }

    public List<Incident> GetIncidentsByCustomerID(int customerID)
        {
            List<Incident> returnList = new List<Incident>();
            foreach(Incident incident in incidents)
            {
                if (incident.CustomerID == customerID)
                {
                    returnList.Add(incident);
                }
            }
            return returnList;
        }

        public void Add(Incident incident)
    {

        if (incident == null)
        {
            throw new ArgumentNullException("Incident cannot be null");
        }

        incidents.Add(incident);

        }

    }
}
