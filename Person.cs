using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
   public class Person : ILoggerManager, IUserManager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string YearOfBirth { get; set; }
        public string IdentificationNumber { get; set; }

        public void DeleteInfo(Person user)
        {
            throw new NotImplementedException();
        }

        public void Login(Person user)
        {
            throw new NotImplementedException();
        }

        public void ReadInfo(Person user)
        {
            throw new NotImplementedException();
        }

        public void SignUp(Person user)
        {
            throw new NotImplementedException();
        }

        public void UpdateInfo(Person user)
        {
            throw new NotImplementedException();
        }
    }
}
