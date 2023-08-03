namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetLineupAvatarDataScRsp
	{
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(2)] public List<LineupAvatarData> AvatarDataList;
	}
	
}
