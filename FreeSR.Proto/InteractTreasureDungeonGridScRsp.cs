namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class InteractTreasureDungeonGridScRsp
	{
		[ProtoMember(12)] public int Retcode;
		[ProtoMember(4)] public ABPFFMGKNAO OBLDGHNJFFA;
	}
	
}
