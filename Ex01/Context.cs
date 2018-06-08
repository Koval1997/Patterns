using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Ex01
{
    public class Context
    {
        private static Dictionary<SocialNetwork, ISocialNetworkTitle> _socialNetworks = new Dictionary<SocialNetwork, ISocialNetworkTitle>();

        static Context()
        {
            _socialNetworks.Add(SocialNetwork.Instagram, new InstagramSubscribers());
            _socialNetworks.Add(SocialNetwork.Twitter, new TwitterSubscribers());
        }

        public static SocialNetworkUser[] DoAlgorithm(SocialNetwork socialnetwork, String username)
        {
            return _socialNetworks[socialnetwork].DoAlgorithm(username);
        }
    }

}
