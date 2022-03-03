namespace Exercise004
{
    public class Item
    {

        public string name { get; set; }
        public int weight { get; set; }
        public Item(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public Item(string name) : this(name, 0)
        {
        }
        public override bool Equals(object compared)
        {
            if (this==compared)
            {
             return true;
            }
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
             return false;
            }
            else
            {
              Item comparedItem = (Item)compared;
              return this.name == comparedItem.name;
            }
        }
        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }
    }
}
