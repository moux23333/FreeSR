namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DelMailCsReq
	{
		[ProtoMember(3)] public List<int> IdList;
	}
	
}
