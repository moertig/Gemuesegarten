using System;
using TestProjekt_WPF451.Model;

namespace TestProjekt_WPF451.Design
{
   public class DesignDataService : IDataService
   {
      public void GetData(Action<DataItem, Exception> callback)
      {
         // Use this to create design time data

         var item = new DataItem("Welcome to MVVM Light [design]");
         callback(item, null);
      }
   }
}