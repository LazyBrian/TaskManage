using DWZ.Repositories;
using DWZ.TaskManage.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWZ.TaskManage.Account
{
    /// <summary>
    /// AddUser1 的摘要说明
    /// </summary>
    public class AddUser1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string userName = context.Request.Form["name"];
            string password = context.Request.Form["password"];

            Models.User user = new Models.User();

            user.UserName = userName;
            user.Password = password;

            IUserRepoistory userRepos = new UserRepoistory();

            bool isSuccess = userRepos.Add(user);

            if (isSuccess)
            {
                Message msg = new Message();

                string returnValue = JsonConvert.SerializeObject(msg, Formatting.Indented);
                context.Response.Write(returnValue);
            }
            else
            {
                Message msg = new Message();
                msg.statusCode = 300;
                msg.message = "操作失败";

                string returnValue = JsonConvert.SerializeObject(msg, Formatting.Indented);
                context.Response.Write(returnValue);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}