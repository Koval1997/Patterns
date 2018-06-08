namespace Patterns.Ex00.ExternalLibs
{
    public class LogImporterClient
    {
        /// <summary>
        /// TODO: Изменения нужно вносить в этом методе
        /// </summary>
        public void DoMethod()
        {
            var importer = new FtpLogReader(new FileLogReader(), new FtpClient());

            importer.ImportLogs("ftp://log.txt");
            importer.ImportLogs("login", "password", "filePath");
        }
    }
}