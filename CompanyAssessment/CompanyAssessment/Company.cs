namespace CompanyAssessment
{
    class Company { 
        public string Name { get; set; }
        public DateTime incorporationDate { get; set; }

        public List<Employee> Employees { get; set; }
        public List<Branch> Branches { get; set; }
        public List<Customer> Customers { get; set; }

        public int GetTotalCustomers()
        {
            Customer cus=new Customer();
            int  TotalCustomers= cus.CustomerId + 1;
            return TotalCustomers;
        }
         


        public float TotalSalaryPayout()
        { 
            Employee emp=new Employee();
            float TotalSalaryPayout += emp.GetSalary();
            return TotalSalaryPayout;

        }
        /*public Employee GetEmployeeByEmpId(long empId)
        {
            
        }*/
        /*public List<Employee>GetExperiencedEmployee(int YearsOfExperience)
        {
            Employee emp=new Employee();
            

        }
        public List<Employee>GetEmployeeGroupByAge(int age)
        {
            Employee emp=new Employee();
            
        }*/
        

    }

}