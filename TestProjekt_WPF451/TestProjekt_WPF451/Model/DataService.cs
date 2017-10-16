using System;

namespace TestProjekt_WPF451.Model
{
   public class DataService : IDataService
   {
      public void GetData(Action<DataItem, Exception> callback)
      {
         // Use this to connect to the actual data service

         var item = new DataItem("Welcome to MVVM Light");
         callback(item, null);
      }
   }
}