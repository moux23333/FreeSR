namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAllLineupDataScRsp
	{
		[ProtoMember(6)] public List<LineupInfo> LineupList;
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(11)] public int CurIndex;
	}

}
