using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSelfHost
{
    public class TechController : System.Web.Http.ApiController
    {
        //-------------------------------------------------Get Devices & Types ---------------------------------------------
        public List<string> GetDeviceTypesNames()
        {
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT Name FROM DeviceTypes", null);
            List<string> lcNames = new List<string>();
            foreach (DataRow dr in lcResult.Rows)
                lcNames.Add((string)dr[0]);
            return lcNames;
        }

        public clsDeviceType GetDeviceType(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Name", Name);
            DataTable lcResult =
        clsDbConnection.GetDataTable("SELECT * FROM DeviceTypes WHERE Name = @Name", par);
            if (lcResult.Rows.Count > 0)
                return new clsDeviceType()
                {
                    Name = (string)lcResult.Rows[0]["Name"],
                    Description = (string)lcResult.Rows[0]["Description"],
                    ProductsList = getProducts(Name)
                };
            else
                return null;
        }

        private List<clsAllProducts> getProducts(string Name)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("Name", Name);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM MobileDevice WHERE DeviceTypeName = @Name", par);
            List<clsAllProducts> lcProducts = new List<clsAllProducts>();
            foreach (DataRow dr in lcResult.Rows)
                lcProducts.Add(dataRow2AllProducts(dr));
            return lcProducts;

        }

        public clsAllProducts getSingleProduct(string ProductCode)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            par.Add("ProductCode", ProductCode);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM MobileDevice WHERE ProductCode = @ProductCode", par);
            clsAllProducts lcProducts = new clsAllProducts();
            foreach (DataRow dr in lcResult.Rows)
                lcProducts = dataRow2AllProducts(dr);
            //lcProducts = lcResult.PrimaryKey;
            return lcProducts;

            //if (lcResult.Rows.Count > 0)
            //    return new clsAllProducts()
            //    {

            //        //DeviceTypeName = (string)lcResult.Rows[0]["DeviceType"],
            //        //Brand = (string)lcResult.Rows[0]["Description"],
            //        //ProductsList = getProducts(Name)
            //    };
            //else
            //    return null;

        }

        private clsAllProducts dataRow2AllProducts(DataRow prDataRow)
        {
            return new clsAllProducts()
            {
                DeviceTypeName = Convert.ToString(prDataRow["DeviceTypeName"]),
                Brand = Convert.ToString(prDataRow["Brand"]),
                ItemDescription = Convert.ToString(prDataRow["ItemDescription"]),
                ProductCode = Convert.ToString(prDataRow["ProductCode"]),
                PricePerItem = Convert.ToDecimal(prDataRow["PricePerItem"]),
                QuantityInStock = Convert.ToInt32(prDataRow["QuantityInStock"]),
                NewOrUsed = Convert.ToChar(prDataRow["NewOrUsed"]),
                ItemCondition = Convert.ToString(prDataRow["ItemCondition"]),
                Warranty = prDataRow["Warranty"] is DBNull ? (int?)null : Convert.ToInt32(prDataRow["Warranty"]),
                DateTimeLastModified = Convert.ToDateTime(prDataRow["DateTimeLastModified"]),
                ProductName = Convert.ToString(prDataRow["ProductName"]),



            };
        }

        //----------------------------------------------- task 3 part 6-----------------------------------
        //-----------------------------------------PUT & POST DEVICE TYPES--------------------------------
        public string PutDeviceType(clsDeviceType prDeviceType)
        {   // update
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "UPDATE DeviceTypes SET Description = @Description WHERE Name = @Name",
        prepareDeviceTypeParameters(prDeviceType));
                if (lcRecCount == 1)
                    return "One Device Type updated";
                else
                    return "Unexpected Device Type update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }
        public string PostDeviceType(clsDeviceType prDeviceType)
        {   // update
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "INSERT INTO DeviceTypes(Name, Description) VALUES (@Name, @Description)",
        prepareDeviceTypeParameters(prDeviceType));
                if (lcRecCount == 1)
                    return "One Device Type added";
                else
                    return "Unexpected Device Type add count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        private Dictionary<string, object> prepareDeviceTypeParameters(clsDeviceType prDeviceType)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(3);
            par.Add("Name", prDeviceType.Name);
            par.Add("Description", prDeviceType.Description);
            
            return par;
        }
        //-----------------------------------------------Task 3 part 6 XV --------------------------------
        //------------------------------------------PUT & POST PRODUCTS-----------------------------------
        public string PostProduct(clsAllProducts prProduct)
        {   // insert
            try
            {
                int lcRecCount = clsDbConnection.Execute("INSERT INTO MobileDevice" +
                "(DeviceTypeName, Brand, ItemDescription, ProductCode, PricePerItem, QuantityInStock, NewOrUsed, ItemCondition, Warranty, DateTimeLastModified, ProductName) " +
                "VALUES (@DeviceTypeName, @Brand, @ItemDescription, @ProductCode, @PricePerItem, @QuantityInStock, @NewOrUsed, @ItemCondition, @Warranty, @DateTimeLastModified, @ProductName)",
                prepareProductParameters(prProduct));
                if (lcRecCount == 1)
                    return "One Product inserted";
                else
                    return "Unexpected Product insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PutProduct(clsAllProducts prProduct)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "UPDATE MobileDevice SET DeviceTypeName = @DeviceTypeName, Brand = @Brand, ItemDescription = @ItemDescription, PricePerItem = @PricePerItem, QuantityInStock = @QuantityInStock, NewOrUsed = @NewOrUsed, ItemCondition = @ItemCondition, Warranty = @Warranty, DateTimeLastModified = @DateTimeLastModified, ProductName = @ProductName WHERE ProductCode = @ProductCode",
        prepareProductParameters(prProduct));
                if (lcRecCount == 1)
                    return "One Product updated";
                else
                    return "Unexpected Product update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message; 
            }

        }
        private Dictionary<string, object> prepareProductParameters(clsAllProducts prProduct)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(10);
            par.Add("DeviceTypeName", prProduct.DeviceTypeName);
            par.Add("Brand", prProduct.Brand); 
            par.Add("ItemDescription", prProduct.ItemDescription);
            par.Add("ProductCode", prProduct.ProductCode);
            par.Add("PricePerItem", prProduct.PricePerItem);
            par.Add("QuantityInStock", prProduct.QuantityInStock);
            par.Add("NewOrUsed", prProduct.NewOrUsed);
            par.Add("ItemCondition", prProduct.ItemCondition);
            par.Add("Warranty", prProduct.Warranty);
            par.Add("DateTimeLastModified", prProduct.DateTimeLastModified);
            par.Add("ProductName", prProduct.ProductName);
            return par;
        }
        //--------------------------------------Delete Products ------------------------------------------

        public string DeleteProduct(string ProductCode, string DeviceTypeName)
        {   // update
            try
            {
                Dictionary<string, object> par = new Dictionary<string, object>(10);
                par.Add("ProductCode", ProductCode);
                par.Add("DeviceTypeName", DeviceTypeName);

                int lcRecCount = clsDbConnection.Execute(
                   "DELETE FROM MobileDevice WHERE ProductCode = @ProductCode AND DeviceTypeName=@DeviceTypeName", par);

                if (lcRecCount == 1)
                    return "One Product deleted";
                else
                    return "Unexpected Product delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }
        //----------------------------------------------- task 3 part 6-----------------------------------
        //----------------------------------------------- ORDERS -----------------------------------------
        public List<clsOrder> GetOrders()
        {
            //string ProductCode = ("IP70012345");
            Dictionary<string, object> par = new Dictionary<string, object>(1);
            //par.Add("ProductCode", ProductCode);
            DataTable lcResult = clsDbConnection.GetDataTable("SELECT * FROM Orders ", null);
            List<clsOrder> lcOrders = new List<clsOrder>();
            foreach (DataRow dr in lcResult.Rows)
                lcOrders.Add(dataRow2AllOrder(dr));
            return lcOrders;

        }

        private clsOrder dataRow2AllOrder(DataRow prDataRow)
        {
            return new clsOrder()
            {
                OrderID = Convert.ToString(prDataRow["OrderID"]),
                ProductCode = Convert.ToString(prDataRow["ProductCode"]),
                ProductName = Convert.ToString(prDataRow["ProductName"]),
                Quantity = Convert.ToInt32(prDataRow["Quantity"]),
                PriceAtTimeOfOrder = Convert.ToDecimal(prDataRow["PriceAtTimeOfOrder"]),
                TimeOfOrder = Convert.ToDateTime(prDataRow["TimeOfOrder"]),
                CustomerDetails = Convert.ToString(prDataRow["CustomerDetails"]),
                DeviceTypeName = Convert.ToString(prDataRow["DeviceTypeName"]),
            };
        }
        public string PostOrder (clsOrder prOrder)
        {   // insert
            try
            {
                int lcRecCount = clsDbConnection.Execute("INSERT INTO Orders " +
                "(OrderID, ProductCode, ProductName, Quantity, PriceAtTimeOfOrder, TimeOfOrder, CustomerDetails, DeviceTypeName) " +
                "VALUES (@OrderID, @ProductCode, @ProductName, @Quantity, @PriceAtTimeOfOrder, @TimeOfOrder, @CustomerDetails, @DeviceTypeName)",
                prepareOrderParameters(prOrder));
                if (lcRecCount == 1)
                    return "Order Succesfully Made";
                else
                    return "Unexpected Order insert count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }

        public string PutOrder(clsOrder prOrder)
        {
            try
            {
                int lcRecCount = clsDbConnection.Execute(
        "UPDATE Orders SET ProductCode = @ProductCode, ProductName = @ProductName, Quantity = @Quantity, PriceAtTimeOfOrder = @PriceAtTimeOfOrder, TimeOfOrder = @TimeOfOrder, CustomerDetails = @CustomerDetails, DeviceTypeName = @DeviceTypeName WHERE OrderID = @OrderID",
        prepareOrderParameters(prOrder));
                if (lcRecCount == 1)
                    return "One Order updated";
                else
                    return "Unexpected Order update count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }

        }
        //----------------------------------------------------Prepare-----------------------------------------------------
        private Dictionary<string, object> prepareOrderParameters(clsOrder prOrder)
        {
            Dictionary<string, object> par = new Dictionary<string, object>(10);
            par.Add("OrderID", prOrder.OrderID);
            par.Add("ProductCode", prOrder.ProductCode);
            par.Add("ProductName", prOrder.ProductName);
            par.Add("Quantity", prOrder.Quantity);
            par.Add("PriceAtTimeOfOrder", prOrder.PriceAtTimeOfOrder);
            par.Add("TimeOfOrder", prOrder.TimeOfOrder);
            par.Add("CustomerDetails", prOrder.CustomerDetails);
            par.Add("DeviceTypeName", prOrder.DeviceTypeName);
            return par;
        }
        //---------------------------------------------------------DELETE--------------------------------------------------
        public string DeleteOrder(string OrderID)
        {   // update
            try
            {
                Dictionary<string, object> par = new Dictionary<string, object>(10);
                par.Add("OrderID", OrderID);
                

                int lcRecCount = clsDbConnection.Execute(
                   "DELETE FROM Orders WHERE OrderID = @OrderID", par);

                if (lcRecCount == 1)
                    return "One Order deleted";
                else
                    return "Unexpected Order delete count: " + lcRecCount;
            }
            catch (Exception ex)
            {
                return ex.GetBaseException().Message;
            }
        }
    }
}
