using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWZ.TaskManage.Tools
{
    public class Message
    {
        public Message()
        {
            statusCode = 200;
            message = "操作成功";
            navTabId = "";
            callbackType = "";
            forwardUrl = "";
        }
        public int statusCode { get; set; }

        public string message { get; set; }

        public string navTabId { get; set; }

        public string callbackType { get; set; }

        public string forwardUrl { get; set; }
    }
}