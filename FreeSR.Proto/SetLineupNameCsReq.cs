namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetLineupNameCsReq
	{
		[ProtoMember(12)] public string Name;
		[ProtoMember(11)] public int Index;
	}
	
}
