namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MissionRewardScNotify
	{
		[ProtoMember(12)] public int MainMissionId;
		[ProtoMember(4)] public ItemList Reward;
		[ProtoMember(15)] public int SubMissionId;
	}
	
}
