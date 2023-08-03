namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MarkReadMailCsReq
	{
		[ProtoMember(8)] public int Id;
	}
	
}
