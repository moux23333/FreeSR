namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetFriendApplyListInfoScRsp
	{
		[ProtoMember(14)] public List<HDFHLILEAMH> CDGBAGFMDOB;
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(8)] public List<int> BEJHCJOOKNL;
	}
	
}
