using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Fleet.NewFolder
{
    public class Car
    {
        //make, model, registration and engine size (cc). Implement a car class and override ToString() 
        public string Make { get; set; }
        public string Model { get; set; }
        [Key]
        public string Registration { get; set; }
        public int EngineSize { get; set; }

        // constructor
        public Car(string Make, string Model, string Registration, int EngineSize)
        {
            this.Make = Make;
            this.Model = Model;
            this.Registration = Registration;
            this.EngineSize = EngineSize;
        }


        // ToString
        public override string ToString()
        {
            return "\n_____" + "Car Details;\nMake: " + Make + "\nModel: " + Model + "\nRegistration: " + Registration + "\nEngine Size (cc) : " + EngineSize + "\n_____";
        }
    }
}
