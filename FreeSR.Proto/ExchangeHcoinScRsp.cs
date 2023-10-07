namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExchangeHcoinScRsp
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(2)] public int Num;
	}

}
