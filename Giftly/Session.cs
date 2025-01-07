using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giftly
{
    class Session
    {
        public static int UserId { get; set; }
        public static String UserEmail { get; set; }
        public static string UserFirstName { get; set; }
        public static string UserLastName { get; set; }

        public static void Clear()
        {
            UserId = 0;
            UserEmail = null;
            UserFirstName = null;
            UserLastName = null;
        }
    }
}
