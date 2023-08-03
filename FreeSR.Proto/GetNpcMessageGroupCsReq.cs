namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetNpcMessageGroupCsReq
	{
		[ProtoMember(11)] public List<int> ContactIdList;
	}
	
}
