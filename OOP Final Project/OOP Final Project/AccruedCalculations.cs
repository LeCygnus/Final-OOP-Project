using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final_Project
{
    public class AccruedCalculations
    {
        public static int MonthsAccrued(string date)
        {
            string[] dateArray = date.Split('/');

            int transactionMonth = Convert.ToInt32(dateArray[0]);
            int transactionDay = Convert.ToInt32(dateArray[1]);
            int transactionYear = Convert.ToInt32(dateArray[2]);

            int currentMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int currentDay = Convert.ToInt32(DateTime.Now.ToString("dd"));
            int currentYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));

            int monthsAccrued = 0;

            // 1/5/16
            if (currentYear > transactionYear) //2018 > 2016
            {
                monthsAccrued = (currentYear - transactionYear) * 12; // 2018 - 2016 = 2 * 12 = 24
            }

            if (currentMonth > transactionMonth) // 3 > 5
            {
                //monthsAccrued = (monthsAccrued + currentMonth) - userMonth;
                if (currentDay >= transactionDay)
                {
                    monthsAccrued = monthsAccrued + (currentMonth - transactionMonth);
                }
                else
                {
                    monthsAccrued = (monthsAccrued + (currentMonth - transactionMonth)) - 1;
                    if (monthsAccrued < 0)
                        monthsAccrued = 0;
                }
            }
            else if (currentMonth == transactionMonth)
            {
                if (currentDay < transactionDay)
                {
                    monthsAccrued = monthsAccrued - 1;
                    if (monthsAccrued < 0)
                        monthsAccrued = 0;
                }
            }
            else// (currentMonth < userMonth)
            {
                if (currentDay >= transactionDay)
                {
                    monthsAccrued = monthsAccrued - (transactionMonth - currentMonth);
                }
                else
                {
                    monthsAccrued = monthsAccrued - (transactionMonth - (currentMonth - 1));
                    if (monthsAccrued < 0)
                        monthsAccrued = 0;
                }
            }

            return monthsAccrued;

        }

        public static decimal AccruedAmount(decimal calcInterest, decimal calcPrincipal, int calcMonth)
        {
            calcInterest = calcInterest / 100;
            return calcPrincipal + (calcPrincipal * calcInterest * calcMonth);
        }
    }
}
