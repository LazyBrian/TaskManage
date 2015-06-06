using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace DWZ.TaskManage
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conStr = "Data Source=(local);Initial Catalog=www;Persist Security Info=True;User ID=sa ;Password=123456";
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "select * from users";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var value = reader.GetValue(0);
                }
                reader.Close();

            }
        }
    }
}