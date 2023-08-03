namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetTreasureDungeonActivityDataScRsp
	{
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(9)] public List<COOEFMOBLKO> ECBLPCDEKHB;
	}
	
}
