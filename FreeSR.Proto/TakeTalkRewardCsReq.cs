namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeTalkRewardCsReq
	{
		[ProtoMember(3)] public int TalkEventId;
		[ProtoMember(12)] public Vector NpcLocation;
	}
	
}
