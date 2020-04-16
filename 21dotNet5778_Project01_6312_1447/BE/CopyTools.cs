using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    /// <summary>
    /// Copy Tools static class
    /// </summary>
    public static class CopyTools
    {
        /// <summary>
        /// static and generics function for "Deep Copy"
        /// </summary>
        public static T DeepClone<T>(this T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
        /// <summary>
        /// static and generics function for "Shallow  Copy"(T have constractor)
        /// </summary>
        public static T GetCopy<T>(this T source) where T : new()
        {
            T result = new T();
            foreach (PropertyInfo item in source.GetType().GetProperties())
            {
                try
                {
                    if (item.CanWrite && item.CanRead) // (item.PropertyType.IsValueType)
                    {
                        object srcValue = item.GetValue(source, null);
                        item.SetValue(result, srcValue);
                    }
                    //else //if(item.PropertyType.IsClass)
                    //{
                    //    object srcValue = item.GetValue(source, null);
                    //    item.SetValue(result, srcValue.GetDeepCopy());
                    //}
                }
                catch (Exception e)
                {
                    Debug.WriteLine($" --->> err copy property {item.Name} from {source.GetType().Name} \n {e.Message}");
                }
            }
            return result;
        }

    }
}
