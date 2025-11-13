using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            Car carLoneInstance = new Car()
            {
                Year = 1927,
                Make = "Ford",
                Model = "Model T",
                Engine = "inline four-cylinder",
                CorporateFounder = "Ford Motor Company: Henry Ford",
                Headquarters = "1 American Road, Dearborn, MI 48126",
                StickShift = true,
                FuelOctaneGrade = "regular"
            };

            SUV suvLoneInstance = new SUV()
            {
                Year = 2006,
                Make = "Hummer (by General Motors)",
                Model = "H3",
                Engine = "inline five-cylinder",
                CorporateFounder = "General Motors: Charles Stewart Mott & William C. Durant",
                Headquarters = "100 Renaissance Center, Detroit, MI 48243",
                Armored = false,
                Terrain = "off-road terrain"
            };

            Truck truckLoneInstance = new Truck()
            {
                Year = 1939,
                Make = "Dodge (by Chrysler)",
                Model = "Pickup Truck",
                Engine = "inline-six diesel engine",
                CorporateFounder = "Chrysler: Walter Percy Chrysler\nDodge Brothers Company: Horace Elgin Dodge & John Francis Dodge",
                Headquarters = "1000 Chrysler Dr, Auburn Hills, MI 48326",
                Fuel = "Diesel",
                Wrecker = false
            };

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
            carLoneInstance.DisplayDetails();
            suvLoneInstance.DisplayDetails();
            truckLoneInstance.DisplayDetails();
        }
    }
}
