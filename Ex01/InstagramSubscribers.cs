using Patterns.Ex01.ExternalLibs.Instagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex01
{
    class InstagramSubscribers : ISocialNetworkTitle
    {
        
        public SocialNetworkUser[] DoAlgorithm(String userName)

        {
            List<SocialNetworkUser> users = new List<SocialNetworkUser>();
            InstagramUser[] instSubscribers = new InstagramClient().GetSubscribers(userName);
            for (int i = 0; i < instSubscribers.Length; i++)
            {
                var user = new SocialNetworkUser();
                user.UserName = instSubscribers[i].UserName;
                users.Add(user);
            }
            return users.ToArray();
        }

    }
}
