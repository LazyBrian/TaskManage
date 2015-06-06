using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWZ.TaskManage.Tools
{
    public class BindingFieldAttribute : System.Attribute
    {
        public string FieldName { get; set; }

    }
}