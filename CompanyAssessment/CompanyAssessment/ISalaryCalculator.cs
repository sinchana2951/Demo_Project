namespace CompanyAssessment
{
    interface ISalaryCalculator
    {
        public static float CalculateAllowance(int experience,float basic)
        {
            float allowance = 0;
            if (experience <=2) {
                allowance = 0.3f*basic;
            }
            else if(experience <=4) 
            {
                allowance = 0.4f*basic;
            }
            else if(experience <=6) 
            {
                allowance = 0.5f * basic;
            }
            else if(experience >6)
            {
                allowance = 0.65f * basic;
            }
            return allowance;
           
        }
    }

}