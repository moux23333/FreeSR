namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MuseumTakeCollectRewardScRsp
	{
		[ProtoMember(10)] public int ItemId;
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(6)] public ItemList Reward;
	}
	
}
