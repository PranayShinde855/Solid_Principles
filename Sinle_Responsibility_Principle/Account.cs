using Single_Responsibility_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinle_Responsibility_Principle
{
    public class Account
    {
        // Siingle Responsibility Principle : A class can oniy have one responsibinilty.
        // Here UerLogin class conains fuction of login only and not contian implemetions of notification
        Notification notification = new Notification();
        public void Login(string userName, string password)
        {
            if(userName!=null && password != null)
            {
                bool check = true; //Check credentials from DB
                if(check == true)
                {
                    notification.SendNotification_LoggedIn();
                }
            }
        }

        public void Registration(string userName, int mobileNo, string password)
        {
            if(userName != null && password != null)
            {
                // SAVE CHANGES IN DP
                notification.SendNotification_Registration();
            }
        }

    }
}
