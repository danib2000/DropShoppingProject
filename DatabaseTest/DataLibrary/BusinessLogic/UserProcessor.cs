using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class UserProcessor
    {
        public static int CreateUser(string userName, String emailAddress, int balance)
        {
            UserModel data = new UserModel
            {
                UserName = userName,
                Email = emailAddress,
                Balance = balance
            };
            string sql = @"insert into dbo.Users( UserName, Email, Balance)
                           values(@UserName, @Email, @Balance);";
            return sqlDataAccess.SaveData(sql, data);
        }

        public static List<UserModel> LoadUsers()
        {
            string sql = @"select UserId, UserName, Email, Balance
                           from dbo.Users;";
            return sqlDataAccess.LoadData<UserModel>(sql);
        }
    }
}
