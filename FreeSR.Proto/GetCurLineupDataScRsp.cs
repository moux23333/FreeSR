namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetCurLineupDataScRsp
	{
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(9)] public LineupInfo Lineup;
	}

}
