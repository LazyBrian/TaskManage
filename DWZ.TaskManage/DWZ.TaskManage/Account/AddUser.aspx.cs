using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DWZ.Repositories;
using DWZ.TaskManage.Tools;
using Newtonsoft.Json;

namespace DWZ.TaskManage.Account
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userName = Request.Form["name"];
            string password = Request.Form["password"];

            Models.User user = new Models.User();

            user.UserName = userName;
            user.Password = password;

            IUserRepoistory userRepos = new UserRepoistory();

            bool isSuccess = userRepos.Add(user);

            if (isSuccess)
            {
                Message msg = new Message();

                string returnValue = JsonConvert.SerializeObject(msg, Formatting.Indented);
                Response.Write(returnValue);
            }
            else
            {
                Message msg = new Message();
                msg.statusCode = 300;
                msg.message = "操作失败";

                string returnValue = JsonConvert.SerializeObject(msg, Formatting.Indented);
                Response.Write(returnValue);
            }
        }
    }
}