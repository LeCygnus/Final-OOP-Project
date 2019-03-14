using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Final_Project
{
    public class AccruedCalculations
    {
        static int MonthsAccruedCalculations(int userDay, int userMonth, int userYear)
        {

            int currentDay = Convert.ToInt32(DateTime.Now.ToString("dd"));
            int currentMonth = Convert.ToInt32(DateTime.Now.ToString("MM"));
            int currentYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));

            int monthsAccrued = 0;

            // 1/5/16
            if (currentYear > userYear) //2018 > 2016
            {
                monthsAccrued = (currentYear - userYear) * 12; // 2018 - 2016 = 2 * 12 = 24
            }

            if (currentMonth > userMonth) // 3 > 5
            {
                //monthsAccrued = (monthsAccrued + currentMonth) - userMonth;
                if (currentDay >= userDay)
                {
                    monthsAccrued = monthsAccrued + (currentMonth - userMonth);
                }
                else
                {
                    monthsAccrued = (monthsAccrued + (currentMonth - userMonth)) - 1;
                    if (monthsAccrued < 0)
                        monthsAccrued = 0;
                }
            }
            else if (currentMonth == userMonth)
            {
                if (currentDay < userDay)
                {
                    monthsAccrued = monthsAccrued - 1;
                    if (monthsAccrued < 0)
                        monthsAccrued = 0;
                }
            }
            else// (currentMonth < userMonth)
            {
                if (currentDay >= userDay)
                {
                    monthsAccrued = monthsAccrued - (userMonth - currentMonth);
                }
                else
                {
                    monthsAccrued = monthsAccrued - (userMonth - (currentMonth - 1));
                    if (monthsAccrued < 0)
                        monthsAccrued = 0;
                }
            }

            return monthsAccrued;

        }

        static double AccruedAmount(double calcInterest, double calcPrincipal, int calcMonth)
        {
            calcInterest = calcInterest / 100;
            return calcPrincipal + (calcPrincipal * calcInterest * calcMonth);
        }
    }
}
