
namespace CrudApp
{
    internal class Customer
    {
        public int CustomerID;
        public string CustomerName;
        public DateTime DOB;
        public bool Licensed;
        public String ContactNumber;

        public Customer() 
        { 
            CustomerID = 0;
            CustomerName = "N/A";
            DOB = DateTime.Now;
            Licensed = false;
            ContactNumber = "N/A";
        }
    }
}
