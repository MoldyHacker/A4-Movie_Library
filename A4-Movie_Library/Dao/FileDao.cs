using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace A4_Movie_Library.Dao
{
    public class FileDao : IDataDao
    {
        private readonly ILogger<FileDao> _logger;

        public FileDao(ILogger<FileDao> logger)
        {
            _logger = logger;
        }

        public void Read()
        {
            throw new NotImplementedException();
            Console.WriteLine("Reading the file");
            _logger.LogInformation("File has been read");
        }

        public void Write()
        {
            throw new NotImplementedException();
            Console.WriteLine("Writing the file");
        }
    }
}
