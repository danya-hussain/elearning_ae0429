using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elearning_ae0429
{
    public class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public string UserJob { get; set; }
        public Users()
        {

        }
        public Users(string userName, string password, string userId, string userJob)
        {
            UserName = userName;
            Password = password;
            UserId = userId;
            UserJob = userJob;
        }
        
    }
}