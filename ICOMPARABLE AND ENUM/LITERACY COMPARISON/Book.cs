namespace Exercise003
{
    using System;
    public class Book : IComparable<Book>
    {

        public string name { get; set; }
        public int ageRecommendation { get; set; }

        public Book(string name, int ageRecommendation)
        {
            this.name = name;
            this.ageRecommendation = ageRecommendation;
        }


        public override string ToString()
        {
            // Don't touch this
            return this.name + " (recommended for " + this.ageRecommendation + " year-olds or older)";
        }


        public int CompareTo(Book other)
        {
           if (this.ageRecommendation == other.ageRecommendation)
           {
               return this.name.CompareTo(other.name);
           }
           return this.ageRecommendation.CompareTo(other.ageRecommendation);
        }

    }
}
