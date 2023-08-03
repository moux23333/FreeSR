namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeRogueEventHandbookRewardScRsp
	{
		[ProtoMember(15)] public List<int> LAFOEBFHDAG;
		[ProtoMember(10)] public ItemList Reward;
		[ProtoMember(6)] public int Retcode;
	}
	
}
