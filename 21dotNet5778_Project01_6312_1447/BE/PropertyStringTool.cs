using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public static class HasNumber
    { 
     public static bool hasNumber(this string input)
    {
        return input.Where(x => Char.IsDigit(x)).Any();
    }
    }
    /// <summary>
    ///Property-String-Tool static class
    /// </summary>    
    public static class PropertyStringTool
     {
        /// <summary>
        /// static and generics function for print all Property info
        /// </summary>    
        public static string ToStringProperty<T>(T t)
        {
            string str = "";
            foreach (PropertyInfo item in t.GetType().GetProperties())
                str += "\n" + item.Name + ": " + item.GetValue(t, null);
            return str;
        }
    }

}
