using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DWZ.Models;

namespace DWZ.Repositories
{
    public interface IUserRepoistory
    {
        List<User> GetAll();

        bool Add(User user);
    }
}
