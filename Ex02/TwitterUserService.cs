using System;
using System.Linq;
using System.Text.RegularExpressions;
using Patterns.Ex01.ExternalLibs.Twitter;

namespace Patterns.Ex02
{
    public class TwitterUserService : UserService<TwitterUser>
    {
        private UserInfo GetUsersInfo(String pageUrl)
        {
            UserInfo userInfo = GetUserInfo(pageUrl);
            return userInfo;
        }
    }
}