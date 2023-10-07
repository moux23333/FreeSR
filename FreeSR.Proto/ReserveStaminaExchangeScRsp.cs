namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ReserveStaminaExchangeScRsp
	{
		[ProtoMember(11)] public int Retcode;
		[ProtoMember(3)] public int Num;
	}

}
