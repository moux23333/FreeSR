namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EntityBuffInfo
	{
		[ProtoMember(8)] public int EntityId;
		[ProtoMember(14)] public List<BuffInfo> BuffList;
	}
	
}
