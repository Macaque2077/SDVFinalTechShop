using System;
using System.Collections.Generic;


namespace TechShopWinForm
{
    public class clsDeviceType
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<clsAllProducts> ProductsList { get; set; }
    }

    public class clsAllProducts
    {
        public string DeviceTypeName { get; set; }
        public string Brand { get; set; }
        public string ItemDescription { get; set; }
        public string ProductCode { get; set; }
        public decimal PricePerItem { get; set; }
        public int QuantityInStock { get; set; }
        public Char NewOrUsed { get; set; }
        public string ItemCondition { get; set; }
        public int? Warranty { get; set; }
        public DateTime DateTimeLastModified { get; set; }
        public string ProductName { get; set; }

        public static readonly string FACTORY_PROMPT = "Enter N for New Product or U for Used Product";

        //Output for the product list listbox 
        public override string ToString()
        {
            return Brand +"\t" + ProductName + "\t" + DateTimeLastModified.ToShortDateString();
        }

        //Cretes new product
        public static clsAllProducts NewProduct(char prChoice)
        {
            return new clsAllProducts() { NewOrUsed = Char.ToUpper(prChoice) };
        }
    }


    public class clsOrder
    {
        public string OrderID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal PriceAtTimeOfOrder { get; set; }
        public DateTime TimeOfOrder { get; set; }
        public string CustomerDetails { get; set; }
        public string DeviceTypeName { get; set; }

        //outputs order details to the screen
        public override string ToString()
        {
            return DeviceTypeName + "\t" + ProductName + "\t" + Quantity;

        }
        //can be used to calculate order total
        public decimal TotalPrice => (Quantity * PriceAtTimeOfOrder);

        //creates new order
        public static clsOrder NewOrder()
        {
            return new clsOrder();
        }
    }

}
