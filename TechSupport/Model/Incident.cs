using System;


namespace TechSupport.Model
{
    public class Incident
    {
        public string Title { get; }
        public string Description { get; }
        public int CustomerID { get; }

        public Incident(string title, string description, int customerID)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title cannot be null or empty", "title");

            }

            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Description cannot be null or empty", "description");

            }

            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "CustomerID has to be greater than 0");
            }

            this.Title = title;
            this.Description = description;
            this.CustomerID = customerID;

        }
    }
}
       
