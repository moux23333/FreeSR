namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MissionEventRewardScNotify
	{
		[ProtoMember(10)] public ItemList Reward;
		[ProtoMember(7)] public int MissionEventId;
	}
	
}
