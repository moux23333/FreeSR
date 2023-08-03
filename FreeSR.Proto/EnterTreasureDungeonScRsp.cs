namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterTreasureDungeonScRsp
	{
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(8)] public ABPFFMGKNAO OBLDGHNJFFA;
	}
	
}
