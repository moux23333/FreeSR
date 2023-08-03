namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MonthCardRewardNotify
	{
		[ProtoMember(3)] public ItemList Reward;
	}
	
}
