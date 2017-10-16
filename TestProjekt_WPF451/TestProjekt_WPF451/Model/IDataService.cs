using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProjekt_WPF451.Model
{
   public interface IDataService
   {
      void GetData(Action<DataItem, Exception> callback);
   }
}
