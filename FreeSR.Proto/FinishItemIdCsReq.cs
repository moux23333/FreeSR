namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishItemIdCsReq
	{
		[ProtoMember(12)] public int TextId;
		[ProtoMember(10)] public int ItemId;
	}
	
}
