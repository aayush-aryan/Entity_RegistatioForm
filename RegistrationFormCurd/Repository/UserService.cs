using RegistrationFormCurd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormCurd.Repository
{
    public class UserService : IUser
    {
        private ApplicationDbContext dbContext;

        public UserService(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public bool Delete(int UserId)
        {
            Users users = new Users();
           var result= dbContext.Users.SingleOrDefault(e => e.UserId == UserId);
            if (result != null)
            {
                dbContext.Users.Remove(result);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Users> GetUsers()
        {
           return dbContext.Users.ToList();
        }

        public bool Login(SignIn signIn)
        {
           var user= dbContext.Users.SingleOrDefault(e=>e.UserName.ToLower() == signIn.UserName.ToLower() && e.Password == signIn.Password);

            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Register(SignUp signUp)
        {
            Users user = new Users();
            user.FirstName = signUp.FirstName;
            user.LastName = signUp.LastName;
            user.UserName = signUp.UserName;
            user.Password = signUp.Password;
          var result=  dbContext.Users.Add(user);
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}
