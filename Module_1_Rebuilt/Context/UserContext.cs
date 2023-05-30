using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1_Rebuilt.Context
{
    public class UserContext
    {
        private static volatile UserContext instance;
        private static object key = new Object();
        private UserContext() { }

        public static UserContext Instance
        {
            get
            {
                if (instance == null)
                    lock (key)
                        instance = new UserContext(); 
                return instance;
            }
        }

        [Key]
        public long UID { get; set; }
        public long UserTypeID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public int FamilyCount { get; set; }
        public bool RememberMe { get; set; } = false;
    }
}
