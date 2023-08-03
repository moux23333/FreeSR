namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetSaveRaidCsReq
	{
		[ProtoMember(2)] public int WorldLevel;
		[ProtoMember(11)] public int RaidId;
	}
	
}
