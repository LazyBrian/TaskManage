using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DWZ.Models;
using DWZ.Repositories;
using DWZ.TaskManage.Tools;

namespace DWZ.TaskManage.Account
{
    public partial class UserManage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public List<User> GetUsers()
        {
            IUserRepoistory userRepos = new UserRepoistory();

            List<User> userList = userRepos.GetAll();

            return userList;
        }
    }
}