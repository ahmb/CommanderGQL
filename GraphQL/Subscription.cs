using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Types;

namespace CommanderGQL.GraphQL
{
    public class Subscription
    {
        [Subscribe]
        [Topic]
#pragma warning disable CA1822
        public Platform OnPlatformAdded(
#pragma warning restore CA1822
            [EventMessage] Platform platform
        )
        {
            return platform;
        }
    }
}