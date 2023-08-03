namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeBpRewardScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(9)] public ItemList Reward;
	}
	
}
