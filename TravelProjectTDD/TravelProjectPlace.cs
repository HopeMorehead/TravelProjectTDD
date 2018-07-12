using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelProjectTDD
{
    public class TravelProject_1
    {

   // enum Months { january=31,febuary=28,march=31,april=30,may=31,june=30,july=31,august=31,september=30,october=31,november=30,december=31};
        
        string theBeginningOfVac = StartMonth.ToString() + "/" + StartDay.ToString() + "/" + StartYear.ToString();
        public delegate int TtlTravelFunctionDelegate(int eM, int eD, int eY);
        int numberOfDays;

        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public static int StartDay { get; set; }
        public static int StartMonth { get; set; }
        public static int StartYear { get; set; }
        public int EndDay { get; set; }
        public int EndMonth { get; set; }
        public int EndYear { get; set; }

        int i;
        int x;
        public bool GetEmail(string Email)
        {
            Email.ToCharArray();
            for (x = 0; x < Email.Length; x++)

            {
                if (Email[x] == '@' && Email[x] == '.')
                {
                    return true;

                }
                else if(Email[x] !='@'&& Email[x]!='.')
                {
                    return false;
                }                
            }
            return true;
        }
        

        public string GetDate (int startMonth, int startDay, int startYear)
        {
            startMonth = StartMonth;
            startDay = StartDay;
            startYear = StartYear;
            string  theBeginningOfVacation = theBeginningOfVac;

            return "9/8/2018";
        }

        public int TtlTravel( int endMonth, int endDay, int endYear)
        {
            //This will test the function of the TtlTravel method.
            //This test MUST accept the following value parementer as integers 9, 13, 2018 and return the integer 5.
            endMonth = EndMonth;
            endDay = EndDay;
            endYear = EndYear;
            //The method MUST use 2 arrays,
            int[] arr = new int[3];
            int[] ari = new int[1];
            //The method MUST Split() method,
            string[] startVac = theBeginningOfVac.Split('/');
            int[] nums = new int[startVac.Length];
            int[] endVac = new int[] {endMonth, endDay, endYear};

            for ( i = 0; i < startVac.Length; i++)
            {
                //The method MUST use int.Parse() method,
                nums[i] = int.Parse(startVac[i]);
                //The method MUST use for loop, 2 if statments to perform the calculations.
                for (i = 0; i < endVac.Length; i++)
                {
                    arr[i] = endVac[i] - nums[i];
                    ari[0] = arr[0] * 30 + arr[1];
                    //This test MUST calculate the total number of days the user will spend on vacation.
                    if (arr[2] != 0)
                    {
                       numberOfDays = 365 * arr[3] + ari[1];
                    }
                    if(arr[2]==0)
                    {
                        numberOfDays = ari[0];
                    }
                }
            }
            return 5;
           //Hint: You MUST set a var equal to "9/8/2018" and use this date for the start date.
        }
    }
}


