https://github.com/neuecc/MessagePack-CSharp/commit/3ff94c22abfa4d73088dba7427479d3719cc48b2#diff-04c6e90faac2675aa89e2176d2eec7d8

// set extensions to default resolver.	
MessagePack.Resolvers.CompositeResolver.RegisterAndSetAsDefault(	
    // enable extension packages first
    ImmutableCollectionResolver.Instance,
    ReactivePropertyResolver.Instance,
    // finaly use standard(default) resolver
    StandardResolver.Instance
);

↓

// set extensions to default resolver.
var resolver = MessagePack.Resolvers.CompositeResolver.Create(
	// enable extension packages first
	ImmutableCollectionResolver.Instance,
	ReactivePropertyResolver.Instance,
	// finaly use standard(default) resolver
	StandardResolver.Instance
);
var options = MessagePackSerializerOptions.Standard.WithResolver(resolver);
// pass options to every time or set as default
MessagePackSerializer.DefaultOptions = options;