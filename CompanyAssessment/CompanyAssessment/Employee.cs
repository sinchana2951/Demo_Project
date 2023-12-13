namespace CompanyAssessment
{
    class Employee:Person
    {
        private int EmpId { get; set; }
        private float Basic { get; set; }
        private int experience { get; set; }

        public float GetSalary()
        {
            float totalSalary=0;
            float totalAllowance = ISalaryCalculator.CalculateAllowance(experience,Basic);
            totalSalary =totalAllowance+Basic ;
            return totalSalary;
        }

    }

}