namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class OpenTreasureDungeonGridScRsp
	{
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(5)] public ABPFFMGKNAO OBLDGHNJFFA;
	}
	
}
