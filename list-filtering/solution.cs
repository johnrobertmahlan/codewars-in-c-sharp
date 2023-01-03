using System;
using System.Collections;
using System.Collections.Generic;

public class ListFilterer
{
   public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
   {
     var nums = new List<int>();

     for(var i=0; i < listOfItems.Count; i++)
     {
        if (!(listOfItems[i] is string))
        {
          nums.Add((int)listOfItems[i]);
        }
      }

     return nums;
   }
}
