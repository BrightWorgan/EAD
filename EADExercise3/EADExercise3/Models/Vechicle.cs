namespace EADExercise3.Models
{
    public class Vechicle
    {
        const double CarTollCharge = 2.00;
        const double PSVTollCharge = 2.00;
        const double BusTollCharge = 2.80;
        const double ElectricCarTollCharge = 0.50;
        const double MotorbikeTollCharge = 2.00;
        const double TractorTollCharge = 8.50;
        const double GoodsTollCharge = 4.10;

        const double DiscountPercentage = 0.20;

        public static String[] VehicleTypes
        {
            get
            {
                return new String[] { "Car", "PSV", "Bus", "ElectricCar", "Motorbike", "Tractor", "Goods" };
            }
        }

        public String VehicleType { get; set; }
        public bool HasETag { get; set; }

        public double Charge
        {
            get
            {
                double toll = 0;

                if (VehicleType == "Car")
                {
                    return CarTollCharge;
                }
                else if (VehicleType == "PSV")
                {
                    return PSVTollCharge;
                }
                else if (VehicleType == "Bus")
                {
                    return BusTollCharge;
                }
                else if (VehicleType == "ElectricCar")
                {
                    return ElectricCarTollCharge;
                }
                else if (VehicleType == "Motorbike")
                {
                    return MotorbikeTollCharge;
                }
                else if (VehicleType == "Tractor")
                {
                    return TractorTollCharge;
                }
                else if (VehicleType == "Goods")
                {
                    return GoodsTollCharge;
                }

                return toll;
            }
        }
    }
}
