using System;

namespace OOP3
{
    class FileLogerService : ILoggerService
    {
        public void log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
