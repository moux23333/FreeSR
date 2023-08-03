namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ScenePlaneEventScNotify
	{
		[ProtoMember(1)] public ItemList GENMDDPLPLN;
		[ProtoMember(10)] public ItemList GCPOAHDKNAH;
	}
	
}
