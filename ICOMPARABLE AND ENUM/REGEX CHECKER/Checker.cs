using System.Text.RegularExpressions;

namespace Exercise004
{
    public class Checker
    {
        public bool DayOfWeek(string str)
        {
          Regex regex = new Regex("mon|tue|wed|thu|fri|sat|sun");
          if(regex.IsMatch(str))
          {
            return true;
          }
          return false;
        }

        public bool AllVowels(string str)
        {
          Regex regex = new Regex("^[aeiou]*$");
          if(regex.IsMatch(str))
          {
            return true;
          }
          return false;
        }

        public bool TimeOfDay(string str)
        {
          Regex regex = new Regex("^(2[0-3]|[01]?[0-9]):([0-5]?[0-9]):([0-5]?[0-9])$");
          if(regex.IsMatch(str))
          {
            return true;
          }
          return false;
        }
    }
}
