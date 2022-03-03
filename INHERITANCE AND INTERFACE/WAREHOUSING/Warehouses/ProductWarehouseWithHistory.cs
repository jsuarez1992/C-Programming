using System;
using System.Collections.Generic;

namespace Exercise003
{
    public class ProductWarehouseWithHistory : ProductWarehouse
    {
        public ChangeHistory history;
        public int initialBalance;

        public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
        {
            this.history = new ChangeHistory();
            AddToWarehouse(initialBalance);
        }
        public string History()
        {
            return this.history.ToString();
        }
        new public void AddToWarehouse(int amount)
        {
           base.AddToWarehouse(amount);
           this.history.Add(this.balance);
        }
        new public int TakeFromWarehouse(int amount)
        {
            int sum= base.TakeFromWarehouse(amount);
            this.history.Add(this.balance);
            return sum;


        }
    }
}
