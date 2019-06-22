﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tech4Universal
{
    class ServiceClient
    {
        internal async static Task<List<string>> GetDeviceTypesNamesAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<List<string>>
            (await lcHttpClient.GetStringAsync("http://localhost:60064/api/tech/GetDeviceTypesNames/"));
        }

        internal async static Task<clsDeviceType> GetDeviceTypeAsync(object prDeviceType)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsDeviceType>
            (await lcHttpClient.GetStringAsync
        ("http://localhost:60064/api/tech/GetDeviceType?Name=" + prDeviceType));
            //throw new NotImplementedException();
        }

        internal async static Task<string> InsertDeviceTypeAsync(clsDeviceType prdeviceType)
        {
            return await InsertOrUpdateAsync(prdeviceType, "http://localhost:60064/api/tech/PostDeviceType", "Post");


            //throw new NotImplementedException();
        }


        //----------------------------------------GET, Insert & Update Product------------------------------------------------
        internal async static Task<clsAllProducts> GetSingleProductAsync(object prProductCode)
        {
            using (HttpClient lcHttpClient = new HttpClient())
                return JsonConvert.DeserializeObject<clsAllProducts>
            (await lcHttpClient.GetStringAsync
        ("http://localhost:60064/api/tech/getSingleProduct?ProductCode=" + prProductCode));
            //throw new NotImplementedException();
        }
        internal async static Task<string> UpdateProductAsync(clsAllProducts prProduct)
        {
            return await InsertOrUpdateAsync(prProduct, "http://localhost:60064/api/tech/PutProduct", "PUT");
        }



        internal async static Task<string> InsertProductAsync(object prProduct)
        {
            return await InsertOrUpdateAsync(prProduct, "http://localhost:60064/api/tech/PostProduct", "Post");
        }
        //--------------------------------------------------------------------------------------------------------------------
        //----------------------------------------Get, Insert & Update Order--------------------------------------------------
        //adapted from GetDeviceTypeAsync---------
//        internal async static Task<clsOrderList> GetOrdersAsync()
        internal async static Task<List<clsOrder>> GetOrdersAsync()
        {
            using (HttpClient lcHttpClient = new HttpClient())
//                return JsonConvert.DeserializeObject<clsOrderList>
                return JsonConvert.DeserializeObject<List<clsOrder>>
            (await lcHttpClient.GetStringAsync
        ("http://localhost:60064/api/tech/getOrders/"));
        }
        internal async static Task<string> UpdateOrderAsync(clsOrder prOrder)
        {
            return await InsertOrUpdateAsync(prOrder, "http://localhost:60064/api/tech/PutOrder", "PUT");
        }

        internal async static Task<string> InsertOrderAsync(object prOrder)
        {
            return await InsertOrUpdateAsync(prOrder, "http://localhost:60064/api/tech/PostOrder", "Post");
        }

        internal async static Task<string> DeleteOrderAsync(clsOrder prOrder)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
            ($"http://localhost:60064/api/tech/DeleteOrder?OrderID={prOrder.OrderID}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        //internal static Task<clsOrder> GetOrderDetailsAsync(clsOrder prOrder)
        //{
        //    using (HttpClient lcHttpClient = new HttpClient())
        //        return JsonConvert.DeserializeObject<clsDeviceType>
        //    (await lcHttpClient.GetStringAsync
        //("http://localhost:60064/api/tech/GetDeviceType?Name=" + prOrder));
        //}



        //----------------------------------------------------------------------------------------------------------------
        //-------------------------------------Update Device Type---------------------------------------------------------
        internal async static Task<string> UpdateDeviceTypeAsync(clsDeviceType prdeviceType)
        {
            return await InsertOrUpdateAsync(prdeviceType, "http://localhost:60064/api/tech/PutDeviceType", "PUT");


            //throw new NotImplementedException();
        }

        //changed Encodign.Default to Encoding.UTF8 as original had error
        private async static Task<string> InsertOrUpdateAsync<TItem>(TItem prItem, string prUrl, string prRequest)
        {
            using (HttpRequestMessage lcReqMessage = new HttpRequestMessage(new HttpMethod(prRequest), prUrl))
            using (lcReqMessage.Content =
        new StringContent(JsonConvert.SerializeObject(prItem), Encoding.UTF8, "application/json"))
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.SendAsync(lcReqMessage);
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }

        internal async static Task<string> DeleteProductAsync(clsAllProducts prProducts)
        {
            using (HttpClient lcHttpClient = new HttpClient())
            {
                HttpResponseMessage lcRespMessage = await lcHttpClient.DeleteAsync
            ($"http://localhost:60064/api/tech/DeleteProduct?ProductCode={prProducts.ProductCode}&DeviceTypeName={prProducts.DeviceTypeName}");
                return await lcRespMessage.Content.ReadAsStringAsync();
            }
        }
    }
}
