using RegistrationFormCurd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormCurd.Repository
{
    public interface IUser
    {
       public List<Users> GetUsers();
       public  bool Login(SignIn signIn);
        public bool Register(SignUp signUp);
        public bool Delete(int UserId);
       // public bool Update(int UserId);

    }
}
