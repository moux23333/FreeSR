namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetCurLineupDataScRsp
	{
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(11)] public LineupInfo Lineup;
	}
	
}
