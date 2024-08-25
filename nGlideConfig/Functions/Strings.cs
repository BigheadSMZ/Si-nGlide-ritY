using System.Collections.Generic;

namespace nGlideConfig
{
    public class Strings
    {
       /*===================================================================================================================================
        * Counts the number of characters in a string and extends it with empty spaces to the input amount.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static string Extend(string InputString, int Length)
        {
            // Count the number of characters in the input string.
            int Count = InputString.Length;

            // Check the number of characters against the desired amount.
            if (Count < Length)
            {
                // If the string is to be lengthened, find out by how much.
                int AddLength = Length - Count;

                // Loop until the string matches the desired number of characters.
                for (int i = 1; i <= AddLength; i++)
                {
                    // Add an empty space to the end of the string.
                    InputString += " ";
                }
            }
            // Return the modified string.
            return InputString;
        }
       /*===================================================================================================================================
        * Takes an integer and converts it to a string and also appends a 0 to the front of the string if the integer is less than 10.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static string IntToStringDoubleDigit(int Value)
        {
            // Check if the input number is less than 10.
            if (Value < 10)
            {
                // If it is, append a 0 and return as a string.
                return ("0" + Value.ToString());
            }
            // Otherwise just return the integer as a string.
            return Value.ToString();
        }
       /*===================================================================================================================================
        * Checks a string for illegal characters, removes them, then returns the string.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static string RemoveIllegalCharacters(string Value)
        {
            // Create an array that contains all illegal characters.
            string[] IllegalArray = { "<", ">", ":", "\"", "'", "/", "\\", "|", "?", "*" };

            // Loop through the array of illegal characters
            foreach (string IllegalChar in IllegalArray)
            {
                // Check the value against the current character and replace if exists.
                Value = Value.Replace(IllegalChar,"");
            }
            // Return the modified string.
            return Value;
        }
       /*===================================================================================================================================
        * Converts a List<string> into a string[] array.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static string[] ListToArray(List<string> StringList)
        {
            // Create a new string array equal in size to the list.
            string[] StringArray = new string[StringList.Count];

            // Loop through all items in the list.
            for (int i = 0 ; i < StringList.Count ; i++)
            {
                // Add the item to the string array.
                StringArray[i] = StringList[i];
            }
            // Return the string array.
            return StringArray;
        }
       /*===================================================================================================================================
        * Converts a string[] array into a List<string>.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static List<string> ArrayToList(string[] StringArray)
        {
            // Create a new string list.
            List<string> StringList = new List<string>{};

            // Loop through all items in the array.
            for (int i = 0 ; i < StringArray.Length ; i++)
            {
                // Add the item to the string array.
                StringList.Add(StringArray[i]);
            }
            // Return the string array.
            return StringList;
        }
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
       /*===================================================================================================================================
        * Combines all elements in an array into a single string, optionally separated by commas.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static string CombineArrayToString(dynamic StringArray, bool Commas = true)
        {
            // Contains the string to return.
            string CombinedString = "";

            // Loop through all strings in the array.
            foreach (string Element in StringArray) 
            {
                // Add the item to the string.
                CombinedString += Element;

                // Tells to separate the string by commas.
                if (Commas) { CombinedString += ","; }

                // Always add a space between the strings.
                CombinedString += " "; 
            }
            // Trim the last space from the string.
            CombinedString = CombinedString.TrimEnd(' ');

            // Also trim the last comma if added.
            if (Commas) { CombinedString = CombinedString.TrimEnd(','); }

            // Return the combined string.
            return CombinedString;
        }
    }
}
