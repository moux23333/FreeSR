namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartRogueCsReq
	{
		[ProtoMember(15)] public int ShopId;
		[ProtoMember(7)] public List<int> BaseAvatarIdList;
		[ProtoMember(12)] public int FHDMOECGJPD;
		[ProtoMember(6)] public List<int> PCNOGANHLGL;
		[ProtoMember(14)] public int CFKCEODLJHK;
	}
	
}
