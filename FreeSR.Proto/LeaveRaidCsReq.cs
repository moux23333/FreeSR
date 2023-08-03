namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LeaveRaidCsReq
	{
		[ProtoMember(7)] public int RaidId;
		[ProtoMember(12)] public bool AEPGMPFJLAG;
	}
	
}
