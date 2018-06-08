using Patterns.Ex01.ExternalLibs.Twitter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex01
{
    public class TwitterSubscribers : ISocialNetworkTitle
    {        
        public SocialNetworkUser[] DoAlgorithm(String userName)

        {
            List<SocialNetworkUser> users = new List<SocialNetworkUser>();
            TwitterUser[] twitterSubscribers = new TwitterClient().GetSubscribers(new TwitterClient().GetUserIdByName(userName));
            for (int i = 0; i < twitterSubscribers.Length; i++)
            {
                var user = new SocialNetworkUser();
                user.UserName = new TwitterClient().GetUserNameById(twitterSubscribers[i].UserId);
                users.Add(user);

            }
            return users.ToArray();
        }

    }
}
