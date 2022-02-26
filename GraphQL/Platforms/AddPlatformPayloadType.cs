using HotChocolate.Types;

namespace CommanderGQL.GraphQL.Platforms
{
    public class AddPlatformPayloadType : ObjectType<AddPlatformPayload>
    {
        protected override void Configure(IObjectTypeDescriptor<AddPlatformPayload> descriptor)
        {
            descriptor.Description("Represents the payload to return for an added platform.");

            descriptor
                .Field(p => p.Platform)
                .Description("Represents the added platform.");

            base.Configure(descriptor);
        }
    }
}