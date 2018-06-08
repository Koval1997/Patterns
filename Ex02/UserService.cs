using Patterns.Ex01.ExternalLibs.Twitter;
using System;

namespace Patterns.Ex02
{
    public class UserService<T>
    {
        public string Parse(string pageUrl)
        {
            return "USER_ID";
        }

        public T[] GetFriendsById(string userId)
        {
            return new T[0];
        }

        public UserInfo[] ConvertToUserInfo(T[] friends)
        {
            return new UserInfo[0];
        }

        public string GetName(string userId)
        {
            return "NAME";
        }

        public UserInfo GetUserInfo(String pageUrl)
        {
            var userId = Parse(pageUrl);

            var result = new UserInfo
            {
                Name = GetName(userId),
                UserId = userId
            };

            T[] subscribers = GetFriendsById(userId);
            var friends = ConvertToUserInfo(subscribers);
            result.Friends = friends;
            return result;
        }

    }
}