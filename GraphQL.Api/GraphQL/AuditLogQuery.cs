using GraphQL.Api.GraphQL.Types;
using GraphQL.Api.Repository;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Api.GraphQL
{
    public class AuditLogQuery : ObjectGraphType
    {
        public AuditLogQuery(LogRepository logRepository)
        {
            Field<ListGraphType<LogType>>(
                "logs",
                resolve: context => logRepository.GetLogs()
                );
        }
    }
}
