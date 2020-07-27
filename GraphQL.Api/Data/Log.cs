using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Api.Data
{
    public class Log
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string ApplicationName { get; set; }
        public bool IsStart { get; set; }
        public string ProcessId { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
