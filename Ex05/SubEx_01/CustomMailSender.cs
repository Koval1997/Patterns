using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Ex05.ExternalLibs;
namespace Patterns.Ex05.SubEx_01
{
    class CustomMailSender : DatabaseSaver
    {
        private MailSender mailSender;
        private string email;
        public CustomMailSender(IDatabaseSaver saver, MailSender mailSender, string email) : base(saver)
        {
            this.mailSender = mailSender;
            this.email = email;
        }
        public new void SaveData(object data)
        {
            base.SaveData(data);
            this.mailSender.Send(email);
        }
    }
}
