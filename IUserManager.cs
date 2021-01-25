using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IUserManager
    {
        void ReadInfo(Person user);
        void UpdateInfo(Person user);
        void DeleteInfo(Person user);
    }
}
