namespace BackendDemo.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public DateTime MFD { get; set; }
        public DateTime EXPD { get; set; }
        public ItemStatus Status { get; set; }

    }
}
