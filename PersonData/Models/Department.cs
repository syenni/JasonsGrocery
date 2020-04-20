using System;

namespace StoreData.Models
{

   public class Department
   {
      public int DepartmentID { get; }
      public int StoreID { get; }
      public DepartmentType DepartmentType { get; }
      public string DepartmentName { get; }
      
      internal Department(int departmentID, DepartmentType departmentType, int storeID,
         string departmentName)
      {
         DepartmentID = departmentID;
         DepartmentType = departmentType;
         StoreID = storeID;
         DepartmentName = departmentName;
      }
   }
}
