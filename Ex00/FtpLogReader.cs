using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Ex00.ExternalLibs;

namespace Patterns.Ex00
{
    class FtpLogReader : LogImporter
    {
        private readonly FtpClient _ftpClient;
        public FtpLogReader(ILogReader reader, FtpClient ftpClient) : base(reader)
        {
            _ftpClient = ftpClient;
        }
        public void ImportLogs(string login, string password, string filePath)
        {
            var file = _ftpClient.ReadFile(login, password, filePath);
            // Do smth
        }
    }
}
