using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace CommanderGQL.GraphQL
{
    /// <summary>
    /// Represents the queries available.
    /// </summary>
    [GraphQLDescription("Represents the queries available.")]
    public class Query
    {
        /// <summary>
        /// Gets the queryable <see cref="Platform"/>.
        /// </summary>
        /// <param name="context">The <see cref="AppDbContext"/>.</param>
        /// <returns>The queryable <see cref="Platform"/>.</returns>
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable platform.")]
        //DO NOT MAKE THESE STATIC !!! GraphQL will blow up with this error:
        //      1. The object type `Query` has to at least define one field in order to be valid. (HotChocolate.Types.ObjectType<CommanderGQL.GraphQL.Query>)
#pragma warning disable CA1822
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)
#pragma warning restore CA1822
        {
            return context.Platforms;
        }

        /// <summary>
        /// Gets the queryable <see cref="Command"/>.
        /// </summary>
        /// <param name="context">The <see cref="AppDbContext"/>.</param>
        /// <returns>The queryable <see cref="Command"/>.</returns>
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        [GraphQLDescription("Gets the queryable command.")]
        //DO NOT MAKE THESE STATIC !!! GraphQL will blow up with this error:
        //      1. The object type `Query` has to at least define one field in order to be valid. (HotChocolate.Types.ObjectType<CommanderGQL.GraphQL.Query>)
#pragma warning disable CA1822
        public IQueryable<Command> GetCommand([ScopedService] AppDbContext context)
#pragma warning restore CA1822
        {
            return context.Commands;
        }
    }
}
