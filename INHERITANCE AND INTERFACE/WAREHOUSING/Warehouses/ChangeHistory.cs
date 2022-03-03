using System;
using System.Collections.Generic;

namespace Exercise003
{
    public class ChangeHistory
    {
        private List<int> history {get; set; }

        public ChangeHistory()
        {
         this.history = new List<int>();
        }
        public void Add(int status)
        {
         this.history.Add(status);
        }
        public void Clear()
        {
         this.history.Clear();
        }
        public int MaxValue()
        {
         int maxValue = 0;
         if (this.history.Count >0)
         {
           maxValue = this.history[0];
           foreach (int valor in this.history)
           {
               if (valor >maxValue)
               {
                   maxValue= valor;
               }
           }
         }
         return maxValue;

        }

        public int MinValue()
        {
         int minValue = 0;
         if (this.history.Count >0)
         {
           minValue = this.history[0];
           foreach (int valor in this.history)
           {
               if (valor < minValue)
               {
                   minValue= valor;
               }
           }
         }
         return minValue;
        }

        public override string ToString()
        {
            return "Current: "+ this.history[this.history.Count -1] + " Min: "+ MinValue() + " Max: " + MaxValue();
        }
    }
