using System.Collections.Generic;

namespace nGlideConfig
{
    public class Strings
    {
       /*===================================================================================================================================
        * Converts a IEnumerable array into a List<string>.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static List<string> EnumToList(IEnumerable<string> EnumArray)
        {
            // Create a new string list.
            List<string> StringList = new List<string>{};

            // Loop through all items in the array.
            foreach(string Item in EnumArray)
            {
                // Add the item to the string array.
                StringList.Add(Item);
            }
            // Return the string array.
            return StringList;
        }
    }
}
