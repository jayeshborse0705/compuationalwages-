namespace EmployeeWageComputational 
{
    class Program2
    {
        public const float EmpWagePerHour = 20;
        public const int FullTime_WorkingHrs_PerDay = 8;
        public const int PartTime_Working_PerDay = 4;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        public float TotalWage = 0;
        public void CalculateWage()
        {
            int DayNumber = 1;
            int EmpWorkingHrs = 0;
            int TotalWorkingHrs = 0;
            while (DayNumber <= MAX_WORKING_DAYS || TotalWorkingHrs <=MAX_WORKING_HRS)
            {
                Random random = new Random();
                int Emp_Check = random.Next(0, 3);
                switch (Emp_Check)
                {
                    case IS_ABSENT:
                        EmpWorkingHrs=0;
                        break;
                    case IS_PART_TIME:
                        EmpWorkingHrs= PartTime_Working_PerDay;
                        break;
                    case IS_FULL_TIME:
                        EmpWorkingHrs=FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage=EmpWorkingHrs*EmpWagePerHour;
                TotalWage +=EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs +=EmpWorkingHrs;
            }
            Console.WriteLine("Total Working days :" +(DayNumber-1) +"\nTotal Working hours:"+ TotalWorkingHrs);
        }
        static void Main(String[] args)
        {
            Program2 obj = new Program2();
            Console.WriteLine("Welcome to employee wage computation");
            obj.CalculateWage();
        }
    }      
}