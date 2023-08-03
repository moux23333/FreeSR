namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetRndOptionCsReq
	{
		[ProtoMember(4)] public int Id;
	}
	
}
