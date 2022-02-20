namespace Single_Responsibility_Principle
{
    public class CustomerRepository
    {
        public void Add(Customer customer)
        {
            try
            {
                // add customer to database
            }
            catch (Exception e)
            {
                // It is not true
               // System.IO.File.WriteAllText("/home/parsajr",e.ToString());
               FileLogger.Log(e.ToString());
            }
        }
        
        
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }      
    }
}