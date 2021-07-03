namespace InventoryMaintenance
{
    public class InvItem
    {
        /*
         * Author: Patrick Kelly
         * Date: 10/23/2018
         */
        private int itemNo;
        private string description;
        private decimal price;

        // Properties that get or sets a data value that contains the item's attribute.
        public int ItemNo
        {
            get { return itemNo; }
            set { itemNo = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        // Returns a string that contains the item's number, description and price formated like this:
        // 1234657    Agapanthus ($7.95)
        public string GetDisplayText() => itemNo.ToString() + "    " + description + " (" + price.ToString("C") + ")";
        

        // InvItem object Constructor with default values
        public InvItem()
        {

        }

        //assigns information to local variables and the properties that get or set each variable
        public InvItem(int itemNo, string description, decimal price)
        {
            this.ItemNo = itemNo;
            this.Description = description;
            this.Price = price;
        }

    }
}
