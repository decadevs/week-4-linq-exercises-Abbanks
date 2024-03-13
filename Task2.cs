using ConsoleTables;

namespace Week4Task
{
    internal class Task2
    {
        public static void Task2Solution()
        {
            List<Item> itemlist = new List<Item> {
            new Item { ItemId = 1, ItemDes = "Bag" },
            new Item { ItemId = 2, ItemDes = "Pen" },
            new Item { ItemId = 3, ItemDes = "Book" },
            new Item { ItemId = 4, ItemDes = "Shoe" },
            new Item { ItemId = 5, ItemDes = "Pin" }
            };

            List<Sales> saleslist = new List<Sales> {
                new Sales{ InvNo = 1, ItemId = 3, Qty = 10 },
                new Sales{ InvNo = 2, ItemId = 2, Qty = 20 },
                new Sales{ InvNo = 3, ItemId = 3, Qty = 500 },
                new Sales{ InvNo = 4, ItemId = 4, Qty = 20 },
                new Sales{ InvNo = 5, ItemId = 3, Qty = 100 },
                new Sales{ InvNo = 6, ItemId = 1, Qty = 50 }
            };

            var innerJoinResult = itemlist.Join(saleslist, i => i.ItemId, s => s.ItemId,
                (i, s) => new
                {
                    itemId = i.ItemId,
                    itemDes = i.ItemDes,
                    qty = s.Qty
                });

            var table = new ConsoleTable("Item Id", "Item Name", "Quantity");
            foreach (var str in innerJoinResult)
            {
                table.AddRow(str.itemId, str.itemDes, str.qty);
            }

            table.Write(); 


        }
    }
}
