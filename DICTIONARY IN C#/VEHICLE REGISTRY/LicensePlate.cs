using System;

namespace Exercise007
{
    public class LicensePlate
    {
        public string liNumber { get; }
        private string country;

        public LicensePlate(string country, string liNumber)
        {
            this.liNumber = liNumber;
            this.country = country;
        }

        public override bool Equals(object compared)
        {
            if (this == compared)
            {
                return true;
            }
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }
            else
            {
                LicensePlate comparedLicensePlate  = (LicensePlate) compared;

                return this.liNumber==comparedLicensePlate.liNumber && this.country==comparedLicensePlate.country;
            }
        }
        public override int GetHashCode()
        {
            return this.liNumber.GetHashCode() + this.country.GetHashCode();
        }

        public override string ToString()
        {
            return country + " " + liNumber;
        }

    }
}
