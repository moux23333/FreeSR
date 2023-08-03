namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExchangeHcoinCsReq
	{
		[ProtoMember(15)] public int Tid;
	}
	
}
