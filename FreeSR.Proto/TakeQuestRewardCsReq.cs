namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeQuestRewardCsReq
	{
		[ProtoMember(12)] public List<int> QuestIdList;
	}
	
}
