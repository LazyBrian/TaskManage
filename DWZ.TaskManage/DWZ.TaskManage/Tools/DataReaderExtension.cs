using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;

namespace DWZ.TaskManage.Tools
{
    public static class DataReaderExtension
    {
        public static List<T> ConvertToList<T>(SqlDataReader dr)
        {
            List<T> tempList = new List<T>();

            while (dr.Read())
            {
                T instance = Activator.CreateInstance<T>();

                //foreach (PropertyInfo property in typeof(T).GetProperties())
                //{
                //    foreach (BindingFieldAttribute field in property.GetCustomAttributes(typeof(BindingFieldAttribute), true))
                //    {
                //        try
                //        {
                //            int ordinal = dr.GetOrdinal(field.FieldName);
                //            if (dr.GetValue(ordinal) != DBNull.Value)
                //            {
                //                property.SetValue(instance, Convert.ChangeType(dr.GetValue(ordinal), property.PropertyType), null);
                //            }
                //        }
                //        catch (Exception)
                //        {
                //            break;
                //        }
                //    }
                //}
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    PropertyInfo property = typeof(T).GetProperty(dr.GetName(i));
                    try
                    {
                        if (dr.GetValue(i) != DBNull.Value)
                        {
                            property.SetValue(instance,Convert.ChangeType(dr.GetValue(i),property.PropertyType),null);
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
                tempList.Add(instance);
            }

            dr.Close();
            return tempList;
        }
    }
}