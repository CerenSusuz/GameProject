using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ILoggerManager
    {
        void Login(Person user); 
        void SignUp(Person user); 
    }
}
