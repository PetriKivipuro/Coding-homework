namespace Exercise
{
    public class ProductWarehouseWithHistory : ProductWarehouse
    {
        public ChangeHistory listChanges;
        public int initialBalance;
        public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
        {
            this.initialBalance = initialBalance;
            this.listChanges = new ChangeHistory();
            AddToWarehouse(initialBalance);
        }

        public string History()
        {
            return this.listChanges.ToString();
        }

        new public void AddToWarehouse(int amount)
        {
            base.AddToWarehouse(amount);
            this.listChanges.Add(this.initialBalance);
        }

        new public int TakeFromWarehouse(int amount)
        {
            base.TakeFromWarehouse(amount);
            this.listChanges.Add(this.initialBalance);
            return amount;
        }
    }
}