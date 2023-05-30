using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1.Context
{
    class UserContext
    {
        public static string strUsername, strPassword;
        public static int iIsEmp, iUID;

        public static string Username
        {
            get { return strUsername; }
            set { strUsername = value; }
        }
        public static string Password
        {
            get { return strPassword; }
            set { strPassword = value; }
        }
        public static int isEmp
        {
            get { return iIsEmp; }
            set { iIsEmp = value; }
        }
        public static int UID
        {
            get { return iUID; }
            set { iUID = value; }
        }
    }
}
