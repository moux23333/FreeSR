namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAllLineupDataScRsp
	{
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(14)] public List<LineupInfo> LineupList;
		[ProtoMember(8)] public int CurIndex;
	}
	
}
