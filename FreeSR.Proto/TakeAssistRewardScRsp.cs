namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeAssistRewardScRsp
	{
		[ProtoMember(11)] public int Retcode;
		[ProtoMember(13)] public ItemList Reward;
	}
	
}
