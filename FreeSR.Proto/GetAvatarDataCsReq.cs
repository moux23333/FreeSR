namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAvatarDataCsReq
	{
		[ProtoMember(15)] public List<int> BaseAvatarIdList;
		[ProtoMember(11)] public bool IsGetAll;
	}

}
