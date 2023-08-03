namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartRaidCsReq
	{
		[ProtoMember(2)] public int PropEntityId;
		[ProtoMember(12)] public int AEPGMPFJLAG;
		[ProtoMember(13)] public int RaidId;
		[ProtoMember(10)] public int WorldLevel;
		[ProtoMember(3)] public List<int> AvatarList;
	}
	
}
