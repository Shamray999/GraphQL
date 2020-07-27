using GraphQL.Api.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Api.Repository
{
    public class LogRepository
    {
        public async Task<List<Log>> GetLogs()
        {
            return new List<Log>()
            {
                new Log()
                {
                    ApplicationName = "SecretCode",
                    Data = "asdlksafkns sklfaskdhgf akd gakdhfg"
                }
            };
        }
    }
}
