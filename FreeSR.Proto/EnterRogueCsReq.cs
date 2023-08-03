namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterRogueCsReq
	{
		[ProtoMember(13)] public int ShopId;
	}
	
}
