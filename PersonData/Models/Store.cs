using System;

namespace StoreData.Models
{
   public class Store
   {
      public int StoreID { get; }
      public string StoreName { get; }

      public Store(int storeID, string storeName)
      {
         StoreID = storeID;
         StoreName = storeName;
      }
   }
}
