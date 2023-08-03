namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetLevelRewardScRsp
	{
		[ProtoMember(9)] public int Level;
		[ProtoMember(10)] public ItemList Reward;
		[ProtoMember(2)] public int Retcode;
	}
	
}
