namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DelSaveRaidScNotify
	{
		[ProtoMember(6)] public int RaidId;
		[ProtoMember(9)] public int WorldLevel;
	}
	
}
