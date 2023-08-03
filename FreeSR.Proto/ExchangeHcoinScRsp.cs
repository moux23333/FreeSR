namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExchangeHcoinScRsp
	{
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(1)] public int Num;
	}
	
}
