namespace EmployeeManagementSystem
{
    
    public class Employees
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        
    }

    public class ShortEmps 
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string EmployeeNum { get; set; }
        public bool NeedsToSign { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string DocSelected { get; set; }

    }
}
