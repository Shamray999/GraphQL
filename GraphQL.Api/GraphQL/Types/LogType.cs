using GraphQL.Api.Data;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Api.GraphQL.Types
{
    public class LogType : ObjectGraphType<Log>
    {
        public LogType()
        {
            Field(t => t.Id);
            Field(t => t.ProcessId);
            Field(t => t.ApplicationName);
            Field(t => t.Data);
            Field(t => t.CreateDateTime);
            Field(t => t.IsStart);
        }
    }
}
