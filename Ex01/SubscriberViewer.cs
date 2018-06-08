using Patterns.Ex01.ExternalLibs.Instagram;
using Patterns.Ex01.ExternalLibs.Twitter;
using System;
using System.Collections.Generic;

namespace Patterns.Ex01
{
    public class SubscriberViewer
    {
        /// <summary>
        /// ���������� ������ ����������� ������������ �� ���.����.
        /// TODO: ���������� �������� ���� ����� �� �������� ������
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="networkType"></param>
        /// <returns></returns>
        public SocialNetworkUser[] GetSubscribers(String userName, SocialNetwork networkType)
        {
           return Context.DoAlgorithm(networkType, userName);

        }
    }
}