namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeAllRewardScRsp
	{
		[ProtoMember(3)] public ItemList Reward;
		[ProtoMember(10)] public int Retcode;
	}
	
}
