using BackendDemo.Models;

namespace BackendDemo.Services
{
    public class ItemServices
    {
        public List<Item> AllItems()
        {
            var myItem = new List<Item>();

            var myItem1 = new Item
            {
                ItemId = 001,
                ItemName = "Ice cream",
                MFD = DateTime.Now,
                EXPD = DateTime.Now.AddDays(10),
                Status = ItemStatus.InStock
            };
            myItem.Add(myItem1);

            var myItem2 = new Item
            {
                ItemId = 002,
                ItemName = "Chockalat Cake",
                MFD = DateTime.Now,
                EXPD = DateTime.Now.AddDays(15),
                Status = ItemStatus.Pocesss
            };
            myItem.Add(myItem2);

            var myItem3 = new Item
            {
                ItemId = 003,
                ItemName = "Apple",
                MFD = DateTime.Now,
                EXPD = DateTime.Now.AddDays(20),
                Status = ItemStatus.Sell
            };
            myItem.Add(myItem3);

            return myItem;
        }
    }
}
