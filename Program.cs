using System;

namespace GameProject
{

    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin()
            {
                Name = "",
                SurName = "",
                YearOfBirth = "",
                IdentificationNumber = "",
                Role = ""
            };

            admin.Login(admin);   //from Person -> ILoggerManager
            admin.UpdateCampaign(); //from Admin -> ICampaignManager
            admin.ReadInfo(admin); //from Person -> IUserManager

            Player player = new Player()
            {
                Name = "",
                SurName = "",
                YearOfBirth = "",
                IdentificationNumber = "",
                UserName = "",
                Password = "",
            };

            player.SignUp(player);  //from Person -> ILoggerManager
            player.DeleteInfo(player); //from Person -> IUserManager
        }
    }
}

