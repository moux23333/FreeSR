namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExchangeGachaCeilingCsReq
	{
		[ProtoMember(15)] public int AvatarId;
		[ProtoMember(6)] public int LLGDAMCHCII;
	}
	
}
