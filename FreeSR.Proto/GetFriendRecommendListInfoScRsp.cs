namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetFriendRecommendListInfoScRsp
	{
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(6)] public List<BCFGGMOOCDA> BOFNLAIFJKD;
	}
	
}
