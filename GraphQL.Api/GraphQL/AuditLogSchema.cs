using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Api.GraphQL
{
    public class AuditLogSchema : Schema
    {
        public AuditLogSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AuditLogQuery>();
        }
    }
}
