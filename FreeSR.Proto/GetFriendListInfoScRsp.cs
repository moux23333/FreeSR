namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetFriendListInfoScRsp
	{
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(13)] public List<BMLOOCFDGFK> FriendList;
		[ProtoMember(4)] public List<FKAEABKBFBP> SimpleInfo;
	}
	
}
