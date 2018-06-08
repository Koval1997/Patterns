using System;

namespace Patterns.Ex02
{
    public class VkUserService: UserService<VkUser>
    {
        private UserInfo GetUsersInfo(String pageUrl)
        {
            UserInfo userInfo = GetUserInfo(pageUrl);
            return userInfo;
        }
    }
}