namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeQuestRewardScRsp
	{
		[ProtoMember(8)] public int Retcode;
		[ProtoMember(6)] public ItemList Reward;
		[ProtoMember(9)] public List<int> SuccQuestIdList;
	}
	
}
