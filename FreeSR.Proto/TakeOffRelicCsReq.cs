namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeOffRelicCsReq
	{
		[ProtoMember(14)] public List<int> RelicType;
		[ProtoMember(12)] public int BaseAvatarId;
	}
	
}
