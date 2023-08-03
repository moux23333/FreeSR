namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExchangeRogueRewardKeyScRsp
	{
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(13)] public int Count;
	}
	
}
