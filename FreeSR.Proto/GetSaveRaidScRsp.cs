namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetSaveRaidScRsp
	{
		[ProtoMember(8)] public int Retcode;
		[ProtoMember(5)] public int RaidId;
		[ProtoMember(13)] public int WorldLevel;
		[ProtoMember(12)] public List<GEAPFJEPNKD> IINHMHPKKML;
		[ProtoMember(6)] public bool AEPGMPFJLAG;
	}
	
}
