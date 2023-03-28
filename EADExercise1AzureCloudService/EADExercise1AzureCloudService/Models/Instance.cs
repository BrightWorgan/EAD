using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EADExercise1AzureCloudService.Models
{
    public class Instance
    {
        const double VerySmallCost = 0.02;
        const double SmallCost = 0.08;
        const double MediumCost = 0.16;
        const double LargeCost = 0.32;
        const double VeryLargeCost = 0.64;
        const double A6Cost = 0.90;
        const double A7Cost = 1.80;


        public static String[] InstanceTypes
        {
            get
            {
                return new String[] { "VerySmall", "Small", "Medium", "Large", "VeryLarge", "A6", "A7" };
            }
        }

        public String InstanceType { get; set;}

        [Required(ErrorMessage = "*Required Field!*")]
        [DisplayName("Instance Size: ")]
        public string InstanceSize { get; set; }

        [Required(ErrorMessage = "* Required field! *")]
        [DisplayName("Number of Instances:")]
        [Range(2, Int32.MaxValue, ErrorMessage = "* ERROR!: Please Select at least two instances *")]

        public int NumOfInstances { get; set; }


        public double AnnualCost
        {
            get
            {
                double cost = 0;

                double year = 365;
                if (DateTime.IsLeapYear(DateTime.Now.Year))
                {
                    return year = 366;
                }

                if (InstanceType == "VerySmall")
                {
                    return VerySmallCost * 24 * year;
                }
                else if (InstanceType == "Small")
                {
                    return SmallCost * 24 * year;
                }
                else if (InstanceType == "Medium")
                {
                    return MediumCost * 24 * year;
                }
                else if (InstanceType == "Large")
                {
                    return LargeCost * 24 * year;
                }
                else if (InstanceType == "VeryLarge")
                {
                    return VeryLargeCost * 24 * year;
                }
                else if (InstanceType == "A6")
                {
                    return A6Cost * 24 * year;
                }
                else if (InstanceType == "A7")
                {
                    return A7Cost * 24 * year;
                }

                return cost;
            }
        }

    }

}    
// hr cost x 24 x 365.25 = annual cost