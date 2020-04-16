using System;
using System.Collections.Generic;


namespace Exercise
{
    public class VehicleRegistry
    {
        private Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();
        public bool Add(LicensePlate licensePlate, string owner)
        {

            if (!this.owners.ContainsKey(licensePlate))
            {
                this.owners.Add(licensePlate, owner);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Get(LicensePlate licensePlate)
        {
            if (this.owners.ContainsKey(licensePlate))
            {
                return this.owners[licensePlate];
            }
            else
            {
                return "No such license";
            }
        }

        public bool Remove(LicensePlate licensePlate)
        {
            if (this.owners.ContainsKey(licensePlate))
            {
                this.owners.Remove(licensePlate);
                return true;
            }

            else
            {

                Console.WriteLine("ei voitu poistaa");
                return false;

            }
        }

        public void PrintLicensePlates()
        {
            foreach (KeyValuePair<LicensePlate, string> kvpLisPla in owners)
            {
                Console.WriteLine("{0}", kvpLisPla.Key);

            }
        }

        public void PrintOwners()
        {
            List<string> listOfOwners = new List<string>();

            foreach (KeyValuePair<LicensePlate, string> kvpowner in this.owners)
            {
                if (!listOfOwners.Contains(kvpowner.Value))
                {
                    Console.WriteLine(kvpowner.Value);
                }
                listOfOwners.Add(kvpowner.Value);
            }

        }
    }
}