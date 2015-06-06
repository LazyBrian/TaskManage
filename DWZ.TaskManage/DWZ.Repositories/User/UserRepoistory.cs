using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using DWZ.Models;

namespace DWZ.Repositories
{
    public class UserRepoistory : IUserRepoistory
    {
        private IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        public List<User> GetAll()
        {
            return this.db.Query<User>("Select * from Users").ToList();
        }

        public bool Add(User user)
        {
            try
            {
                string sql = "Insert into Users values(newid(),@UserName,@Password)";

                var returnId = this.db.Execute(sql, user);

                return returnId > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public User GetUserById(int Id)
        {
             return this.db.Query<User>("select * from Users where Id=@Id").SingleOrDefault();
        }
        
    }
}
