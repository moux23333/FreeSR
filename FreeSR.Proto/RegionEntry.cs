namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RegionEntry
	{
		[ProtoMember(1)] public string Name;
		[ProtoMember(2)] public string Title;
		[ProtoMember(3)] public string DispatchUrl;
		[ProtoMember(4)] public string EnvType;
		[ProtoMember(5)] public string DisplayName;
		[ProtoMember(6)] public string Msg;
	}
	
}
