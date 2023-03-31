namespace EADExercise_2.Models
{
  
    public class Redundancy
    {
        const double Geo1TBCost = 0.125;
        const double GeoTBPlusCost= 0.11;
        const double Loc1TBCost = 0.125;
        const double LocTBPlusCost = 0.125;

        // if redundancy is geo and monthlyUse is less than 1TB charge x
        // if redundancy is geo and monthlyUse is greater than 1TB, charge y x
        // if redundancy is loc and monthlyUse is less than 1TB charge x
        // if redundancy is loc and monthlyUse is greater than 1TB charge y x

        // 1 TB = 1000GB
        // if monthyUse is <1000
        // if monthyUse is >1000, cost = monthyUse-1000, 

        public static String[] RedundancyTypes
        {
            get
            {
                return new String[] { "Geographically", "Locally" };
            }
        }

        public String RedundancyType { get; set; }

        public double MonthlyCharge {
            get
            {
                double value = 0;

                if (RedundancyType == "Geographically")
                {
                    if (MonthlyCharge < 1000)
                    {
                        return Geo1TBCost * MonthlyCharge;
                    }
                    else if (MonthlyCharge > 1000)
                    {
                        if (MonthlyCharge > 1999)
                        {
                            value = MonthlyCharge - 1000;
                            return Geo1TBCost + GeoTBPlusCost * value;
                        }
                    }
                }
                else if (RedundancyType == "Locally")
                {
                    if (MonthlyCharge < 1000)
                    {
                        return Loc1TBCost * MonthlyCharge;
                    }
                    else if (MonthlyCharge > 1000)
                    {
                        if (MonthlyCharge > 1999)
                        {
                            value = MonthlyCharge - 1000;
                            return Loc1TBCost + LocTBPlusCost * value;
                        }
                    }
                }
                return value;
            }     
        }
    }
}
