uusing System;
using System.Collections.Generic;

namespace Exercise007
{
    public class VehicleRegistry
    {
        private Dictionary<LicensePlate, string> register;
        public VehicleRegistry()
        {
            this.register = new Dictionary<LicensePlate, string>();
        }

        public bool Add(LicensePlate licensePlate, string owner)
        {

            if (this.register.ContainsKey(licensePlate))
            {
                return false;
            }
            else
            {
              this.register.Add(licensePlate, owner);
            return true;
            }

        }
        public string Get(LicensePlate licensePlate)
        {
            if (this.register.ContainsKey(licensePlate))
            {
                return this.register[licensePlate];
            }
            return "License Plate not found. Try Again.";
        }
        public bool Remove(LicensePlate licensePlate)
        {
            if (this.register.ContainsKey(licensePlate))
            {
                this.register.Remove(licensePlate);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PrintLicensePlates()
        {
            foreach (KeyValuePair<LicensePlate, string> kvp in this.register)
            {
                Console.WriteLine(kvp.Key);
            }
        }
        public void PrintOwners()
        {
            List<string> owners = new List<string>();
            foreach (KeyValuePair<LicensePlate, string> kvp in this.register)
            {
                if (!owners.Contains(kvp.Value))
                {
                  Console.WriteLine("{0}" , kvp.Value);
                }
                owners.Add(kvp.Value);
            }
        }

    }
}
