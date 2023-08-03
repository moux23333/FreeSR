namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SubMissionRewardScNotify
	{
		[ProtoMember(7)] public int SubMissionId;
		[ProtoMember(8)] public ItemList Reward;
	}
	
}
