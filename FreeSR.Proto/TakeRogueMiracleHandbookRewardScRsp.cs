namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeRogueMiracleHandbookRewardScRsp
	{
		[ProtoMember(1)] public ItemList Reward;
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(15)] public List<int> DEMBGBOOAEB;
	}
	
}
