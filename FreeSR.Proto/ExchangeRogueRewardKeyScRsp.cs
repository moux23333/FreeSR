namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExchangeRogueRewardKeyScRsp
	{
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(4)] public int Count;
	}

}
