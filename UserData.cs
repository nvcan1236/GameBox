using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon_GameBox
{
    public class UserData
    {
        public string userName;
        public string passWord;
        public string[][] history;

        public UserData(string username, string password)
        {
            this.userName = username;
            this.passWord = password;
            history = new string[0][];
        }
    }
}
