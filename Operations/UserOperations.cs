using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DA;
using Models;
using System.Configuration;

namespace Operations
{
    public class UserOperations
    {

        public User Login(string userName, string password)
        {
            DataAccess dal = new DataAccess();
            User user = dal.GetUser(userName);
           if (user!=null)
            {
                Security secure = new Security();
                if(secure.VerifyHash(password, user.password))
                {
                    return user;
                }
           }
            return user;
        }

        public void AddUser(User user)
        {
            Security secure = new Security();
            user.password = secure.HashSHA1(user.password);

            DataAccess dal = new DataAccess();
            dal.AddUser(user);
        }
        public void DeleteUser(User user)
        {
            DataAccess dal = new DataAccess();
            dal.DeleteUser(user);
        }
        public void UpdateUser(User user)
        {
            Security secure = new Security();
            user.password = secure.HashSHA1(user.password);
            DataAccess dal = new DataAccess();
            dal.UpdateUser(user);
        }

        public IList<User> view()
        {
            DataAccess dal = new DataAccess();
            return dal.RetrieveUsers();
        }
        public IList<OrderDetails> generateDet(DateTime d1, DateTime d2, int id)
        {
            DataAccess da = new DataAccess();
            return da.generate(d1, d2, id);
        }
        
    }
}
