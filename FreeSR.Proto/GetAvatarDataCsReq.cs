namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAvatarDataCsReq
	{
		[ProtoMember(9)] public List<int> BaseAvatarIdList;
		[ProtoMember(1)] public bool IsGetAll;
	}
	
}
